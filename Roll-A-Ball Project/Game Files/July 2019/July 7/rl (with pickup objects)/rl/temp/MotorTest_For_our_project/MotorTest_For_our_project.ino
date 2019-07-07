// Adafruit Motor shield library
// copyright Adafruit Industries LLC, 2009
// this code is public domain, enjoy!

#include <AFMotor.h>

AF_DCMotor motor4(4);
AF_DCMotor motor3(3);
AF_DCMotor motor2(2);
AF_DCMotor motor1(1);
int switchStateL = 0;
int switchStateR = 0;
void setup() {
  pinmode(A0,INPUT);
  pinmode(A1,INPUT);
  
  Serial.begin(9600);
  Serial.println("closes");

  
  //last wheel move forward;
;  Serial.print("close");
  
  
    motor4.run(FORWARD);
    motor4.setSpeed(1000);  
    delay(1000);
              
    motor3.run(FORWARD);            
   motor3.setSpeed(1000);
   delay(1000);  
    

     motor2.run(FORWARD);
   motor2.setSpeed(1000); 
   delay(1000) 
    
;    motor1.run(FORWARD);
    motor1.setSpeed (1000)
;   delay(1000)

  if (switchState == LOW)
;    motor4.run(BACKWARD);
    motor4.setSpeed(1000);  
    delay(1000);
              
    motor3.run(FORWARD);            
   motor3.setSpeed(1000);
   delay(1000);  
    

     motor2.run(FORWARD);
   motor2.setSpeed(1000); 
   delay(1000) 
    
;    motor1.run(BACKWARD);
    motor1.setSpeed (1000)
;   delay(1000)


;    motor4.run(BACKWARD);
    motor4.setSpeed(2000);  
    delay(1000);
              
    motor3.run(BACKWARD);            
   motor3.setSpeed(2000);
   delay(1000);  
    

     motor2.run(BACKWARD);
   motor2.setSpeed(2000); 
   delay(1000) 
    
;    motor1.run(BACKWARD);
    motor1.setSpeed (2000)
;   delay(1000)

    
; }
   void loop (){
  switchStateL = digitalRead(A0)
  switchStateR = digitalRead(A1)
    //end closing
   }


