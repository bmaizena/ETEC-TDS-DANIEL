int vermelho = 2;
int verde = 3;
int amarelo = 4;              
void setup() {
  Serial.begin(9600); 
  pinMode(verde,OUTPUT);    
  pinMode(vermelho,OUTPUT); 
  pinMode(amarelo,OUTPUT);         
}

void loop() {
  digitalWrite(vermelho, HIGH);
  delay(5000);
  digitalWrite(vermelho, LOW);
  digitalWrite(verde, HIGH);
  delay(3000);
  digitalWrite(verde, LOW);
  digitalWrite(amarelo, HIGH);
  delay(1000);
  digitalWrite(amarelo, LOW);
}
 