//Define Pins

int pinD1 = 3;
int pinD0 = 5;
 
//int enableB = 7;
int pinE1 = 9;
int pinE0 = 6;
 
//Define Run variable
boolean run;
void setup() {
 
 //pinMode(enableA, OUTPUT);
 pinMode(pinD1, OUTPUT);
 pinMode(pinD0, OUTPUT);
 
 //pinMode(enableB, OUTPUT);
 pinMode(pinE1, OUTPUT);
 pinMode(pinE0, OUTPUT);
 Serial.begin(19200);
 run = true;
 
}
 
//command sequence
void loop() {
 
 if(run)
 {
   if(Serial.available()){
    char pRec = Serial.read();
  if(pRec == 'E'){
    esquerda();
  }else if(pRec == 'D'){
    direita();
 }else if(pRec == 'F'){
parafrente();
}else if(pRec == 'T'){
  paratras();
}else{
desliga();
}
   
 
 //run = false;
 }
 
}}
 
 

 
 void desliga()
 {
 analogWrite(pinD1, 0); 
 analogWrite(pinD0, 0); 
 analogWrite(pinE1, 0); 
 analogWrite(pinE0, 0); 
 }

void parafrente()
{
 analogWrite(pinD1, 150); 
 analogWrite(pinD0, 0); 
 analogWrite(pinE1, 150); 
 analogWrite(pinE0, 0); 
}
 
void paratras()
{
 analogWrite(pinD1, 0); 
 analogWrite(pinD0, 200); 
 analogWrite(pinE1, 0); 
 analogWrite(pinE0, 200); 
}
 

 
//coasting and braking
void esquerda()
{
 analogWrite(pinD1, 0); 
 analogWrite(pinD0, 80); 
 analogWrite(pinE1, 80); 
 analogWrite(pinE0, 0); 
}
 
void direita()
{
 analogWrite(pinD1, 80); 
 analogWrite(pinD0, 0); 
 analogWrite(pinE1, 0); 
 analogWrite(pinE0, 80); 
}
 

 
void stopf()
{
 analogWrite(pinD1, 0); 
 analogWrite(pinD0, 50); 
 analogWrite(pinE1, 0); 
 analogWrite(pinE0, 50); 
}

void stopt()
{
 analogWrite(pinD1, 200); 
 analogWrite(pinD0, 0); 
 analogWrite(pinE1, 200); 
 analogWrite(pinE0, 0); 
}


