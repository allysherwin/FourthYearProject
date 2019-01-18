int incoming = -1;
int mes[2] = {-1, -1};

void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  Serial.println("READY");
}

void loop() {

  if (Serial.available() >0)
  {
    static char input[6];
    static uint16_t i;
    char c = Serial.read();
    

    if (c != '\r' && c != '\n' && i < 5)
      input[i++] = c;
    else 
    {
      input[i] = '\0';
      i = 0;

      uint16_t array[6];
      uint16_t j = 0;
      
      if (!strncmp(input, "CALL", 4))
      {

        char* p = input+4;
        while ( (p = strchr(p, ' ')) != NULL )
          array[j++] = strtol(p, &p, 16);

        
        Serial.println("FOUND");
        digitalWrite(13, HIGH);
        delay(100);
        digitalWrite(13, LOW);
        delay(100);
        digitalWrite(13, HIGH);
        delay(100);
        digitalWrite(13, LOW);
        delay(100);
        digitalWrite(13, HIGH);
        delay(100);
        digitalWrite(13, LOW);
      }
    }

  }

}
