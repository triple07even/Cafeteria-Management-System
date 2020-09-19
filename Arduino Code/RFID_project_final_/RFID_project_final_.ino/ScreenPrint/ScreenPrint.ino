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
