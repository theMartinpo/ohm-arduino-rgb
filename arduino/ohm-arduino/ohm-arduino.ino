#include <LiquidCrystal.h>
#include <Wire.h>

#define REDLITE 3
#define GREENLITE 5
#define BLUELITE 6

LiquidCrystal lcd(7,8,9,10,11,12);
int R = 255;
int G = 20;
int B = 0;
int brightness = 255;
bool rainbow = false;

byte mando[8] = {
  B01110,
  B11111,
  B10001,
  B11011,
  B11011,
  B11111,
  B00000,
};

byte degCelcuis[8] = {
  B00110,
  B01001,
  B01001,
  B00110,
  B00000,
  B00000,
  B00000,
};


char c;

void setup()
{
  pinMode(REDLITE, OUTPUT);
  pinMode(GREENLITE, OUTPUT);
  pinMode(BLUELITE, OUTPUT);

  lcd.createChar(0, mando);
  lcd.createChar(1, degCelcuis);

  setBacklight(255,20,0);
  
  lcd.begin(16,2);
  lcd.print("  ");
  lcd.write(byte(0));
  lcd.print("  Hello!  ");
  lcd.write(byte(0));
  lcd.print("  ");
  delay(3000);
  lcd.clear();
  Serial.begin(9600);
}

void loop()
{
  if (Serial.available() > 0) {
    delay(100);
    lcd.clear();
    lcd.setCursor(0, 0);
    int charCount = 1;
    R = 0 ;
    G = 0 ;
    B = 0 ;
    brightness = 0;
    rainbow = false;
    while (Serial.available() > 0) {
      c = Serial.read();
      if(charCount <=33){
        if (c == '-') {
          lcd.setCursor(0, 1);
        }else if(c == '_'){
          lcd.write(1);
        }else if(c == '#'){
          lcd.write(byte(0));
        }
        else {
          lcd.write(c);
        }
      } else{
        if(charCount == 34 && c == '1' ){
          //rainbow
          rainbow = true;
        } else {
          //rgb
          if(charCount == 35){
            R+=((int)c - 48)*100;
          } else if(charCount == 36){
            R+=((int)c - 48)*10;
          } else if(charCount == 37){
            R+=((int)c - 48)*1;
          }
          if(charCount == 38){
            G+=((int)c - 48)*100;
          } else if(charCount == 39){
            G+=((int)c - 48)*10;
          } else if(charCount == 40){
            G+=((int)c - 48)*1;
          }
          if(charCount == 41){
            B+=((int)c - 48)*100;
          } else if(charCount == 42){
            B+=((int)c - 48)*10;
          } else if(charCount == 43){
            B+=((int)c - 48)*1;
          }
          if(charCount == 44){
            brightness+=((int)c - 48)*100;
          } else if(charCount == 45){
            brightness+=((int)c - 48)*10;
          } else if(charCount == 46){
            brightness+=((int)c - 48)*1;
          }
        }
      }
      charCount++;
      
    }
    
  }

  if (rainbow){
    for (int i = 0; i < 255; i++) {
      setBacklight(i, 0, 255-i);
      delay(5);
    }
    for (int i = 0; i < 255; i++) {
      setBacklight(255-i, i, 0);
      delay(5);
     }
     for (int i = 0; i < 255; i++) {
      setBacklight(0, 255-i, i);
      delay(5);
    }
  } else {
    setBacklight(R,G,B);
  }
}

void setBacklight(uint8_t r, uint8_t g, uint8_t b) {
  // normalize the red LED - its brighter than the rest!
  r = map(r, 0, 255, 0, 100);
  g = map(g, 0, 255, 0, 150);
 
  r = map(r, 0, 255, 0, brightness);
  g = map(g, 0, 255, 0, brightness);
  b = map(b, 0, 255, 0, brightness);
 
  // common anode so invert!
  r = map(r, 0, 255, 255, 0);
  g = map(g, 0, 255, 255, 0);
  b = map(b, 0, 255, 255, 0);
  
  analogWrite(REDLITE, r);
  analogWrite(GREENLITE, g);
  analogWrite(BLUELITE, b);
}
