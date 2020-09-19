#include <Wire.h>
#include <SPI.h>
#include <MFRC522.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>


#define SS_PIN 10
#define RST_PIN 9
 
MFRC522 rfid(SS_PIN, RST_PIN); // Instance of the class

MFRC522::MIFARE_Key key; 

#define SCREEN_WIDTH 128 // OLED display width, in pixels
#define SCREEN_HEIGHT 64 // OLED display height, in pixels

// Declaration for an SSD1306 display connected to I2C (SDA, SCL pins)
#define OLED_RESET     4 // Reset pin # (or -1 if sharing Arduino reset pin)
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);


String serialinputString = "", uidString, nameCheck = "";
boolean stringComplete = false;
String StudentName = "";      
int serialHintInt = serialinputString.length() - 3;

// Init array that will store new NUID 
byte nuidPICC[4];

void setup() { 
  Serial.begin(9600);
  SPI.begin(); // Init SPI bus
  rfid.PCD_Init(); // Init MFRC522 
  display.begin(SSD1306_SWITCHCAPVCC, 0x3C);  // initialize with the I2C addr 0x3D (for the 128x64)
  display.clearDisplay();
 display.display();
  delay(2000); // Pause for 2 seconds



  for (byte i = 0; i < 6; i++) {
    key.keyByte[i] = 0xFF;
  }
   delay(2000);
   readyScreen();
   pinMode(A0, OUTPUT);
  digitalWrite(A0, HIGH);
}
 
void loop() {
  
checkforTag();

delay(100);

recievefromSoftware();
  }

void checkforTag(){
  // Look for new cards
  if ( ! rfid.PICC_IsNewCardPresent())
    return;

  // Verify if the NUID has been readed
  if ( ! rfid.PICC_ReadCardSerial())
   return;

  MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);

  if (piccType != MFRC522::PICC_TYPE_MIFARE_MINI &&  
    piccType != MFRC522::PICC_TYPE_MIFARE_1K &&
    piccType != MFRC522::PICC_TYPE_MIFARE_4K) {
    display.clearDisplay();
    display.display();
    display.setTextColor(WHITE); // or BLACK);
    display.setTextSize(2);
    display.setCursor(0,10); 
    display.print("Rejected");
    //display.display();
   display.setTextSize(1);
   display.setCursor(0,30); 
   display.print("");
 
    display.setTextSize(1);
    display.setCursor(0,50); 
    display.print("Not of institution");
    display.display();
    return;
  }
    printDec(rfid.uid.uidByte, rfid.uid.size);
    scanUID();
    Serial.println();
    
  // Halt PICC
  rfid.PICC_HaltA();

  // Stop encryption on PCD
  rfid.PCD_StopCrypto1();
}

void recievefromSoftware(){
    while(stringComplete){
stringComplete = false;
//     message = serialinputString.substring(0,messageL);
     StudentName = serialinputString.substring(0,serialinputString.length()-3);
    Serial.println(serialinputString);
     Serial.println(StudentName);
     Serial.println("");
     delay(10);
//     
//     if(message.equals("Accepted")){
//  digitalWrite(A0, HIGH); 
//  delay(100);             
//  digitalWrite(A0, LOW);  
  //   }
     //Accepted!Ugochukwu# Rejected!Ugochukwu#
//   
//    if(message.equals("Rejected")){
//     for(int i = 1; i <= 3; i++){
//  digitalWrite(A0, HIGH);   // turn the LED on (HIGH is the voltage level)
//  delay(100);              // wait for a second
//  digitalWrite(A0, LOW);    // turn the LED off by making the voltage LOW
//  delay(100);  
//     }
  //  }

if(serialinputString.endsWith("mf0")){
  displayMessage("Rejected","- - -", "Not of institute");
  }
else if(serialinputString.endsWith("mf1")){
  displayMessage("Rejected","Name: " +  StudentName,"Out of ticket"); 
}
else if(serialinputString.endsWith("mf2")){
   displayMessage("Man Hunt","Name: " +  StudentName, "Wanted by admin");
}
else if(serialinputString.endsWith("mf3")){
   displayMessage("Rejected", "Name: " + StudentName, "Already Served");
}
else if(serialinputString.endsWith("mf4")){
  displayMessage("Accepted", StudentName, ""); 
}
else if(serialinputString.endsWith("mf5")){
   displayMessage("Rejected", "- - -", "Not in Record");
  }
else{
   displayMessage("ERROR", "", "Invalid Command");
  }

     
 readyScreen();  
delay(10);
    serialinputString = "";
 StudentName = "";
    }
  }


void printDec(byte *buffer, byte bufferSize) {
  for (byte i = 0; i < bufferSize; i++) {
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], DEC);
  }
}

void serialEvent() {
  while (Serial.available()) {
    char inChar = (char)Serial.read();
    if(inChar != '\n') {
    serialinputString += inChar;
    }
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}

 void readyScreen(){
  delay(1000);
  display.clearDisplay();
  display.display();
  display.setTextColor(WHITE); // or BLACK);
  display.setTextSize(1);
  display.setCursor(0,0); 
  display.print("Adeleke Uni. Ventures");
  //display.display();
  
  //display.setTextColor(WHITE); // or BLACK);
  display.setTextSize(2);
  display.setCursor(0,10); 
  display.print("Ready");
  display.display();
//19,834  \n\n\nPlace tag to verify
   }


    void scanUID(){
  display.clearDisplay();
  display.display();
  display.setTextColor(WHITE); // or BLACK);
  display.setTextSize(2);
  display.setCursor(0,10); 
  display.print("Verifying");
  display.display();
  }
  
//void printResult(){
//display.clearDisplay();
//    display.display();
//    display.setTextColor(WHITE); // or BLACK);
//    display.setTextSize(2);
//    display.setCursor(0,10); 
//    display.print(message);
//   // display.display();
//
////   display.setTextColor(WHITE);
//   display.setTextSize(1);
//   display.setCursor(0,30); 
//   display.print("Name: " + StudentName);
//  
// //  display.setTextSize(1);
//   display.setCursor(0,50); 
//   display.print(hint);
//  
//   display.display();
//}

 
void displayMessage(String mess, String Name, String hint){
    display.clearDisplay();
    display.display();
    display.setTextColor(WHITE); // or BLACK);
    display.setTextSize(2);
    display.setCursor(0,10); 
    display.print(mess);
    //display.display();

  //  display.display();
 //  display.setTextColor(WHITE);
   display.setTextSize(1);
   display.setCursor(0,30); 
   display.print(Name);
   //display.display();

//     display.display();
    //display.setTextColor(WHITE); // or BLACK);
    //display.setTextSize(1);
    display.setCursor(0,50); 
    display.print(hint);
    display.display();
}
