
void setup() {

  size(500, 500);
}


void draw() {

  background(128);

  // float p = mouseX / (float) width;
 // float p = millis() / 2000.0;
  //float size = lerpy(50, 300, p);

  //map(inA, inB, inVal, outA, outB);
float size = mappy(mouseX, 0, width, 50, 300);
  //fill(p * 255);
  ellipse(width/2, height/2, size, size);
}
float mappy(float inVal, float inMin, float inMax, float outMin, float outMax){
 
  
  //find p
 //float p = 0;
 
 float p = (inVal - inMin) / (inMax -inMin);
 
 //lerp with p
 return lerpy(outMin, outMax, p);
 
}
// Lerp Functions (with overloading)
float lerpy(float min, float max, float p) {
  return lerpy(min, max, p, true);
}

float lerpy(float min, float max, float p, boolean allowExtrapolation) {
  if (!allowExtrapolation) {
    if (p > 1) p = 1;
    if (p < 0) p = 0;
  }

  float range = max - min;
  float offset = range * p;

  return min + offset;
  // return min + (max - min) * p;
}
