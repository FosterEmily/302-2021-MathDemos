
float valStart = 0;
float valEnd = 500;

float animLength = 2;
float animPlayheadTime = 0;

boolean isTweenPlaying = false;

float preTimestamp = 0;

void setup()
{
  
  size(500,500);
  
}

void draw()
{
  
  background(128); //fills the screen with 50% grey
  
  
  float currentTimestamp = millis()/1000.0;
  float dt = currentTimestamp - preTimestamp;
  preTimestamp = currentTimestamp;
  
  //moves playhead forward in time
  if(isTweenPlaying) 
  {
    animPlayheadTime += dt;
    if(animPlayheadTime > animLength) 
    {
      isTweenPlaying = false;
      animPlayheadTime= animLength;
    }
  }
  
  
  
  //percent:
  float p = animPlayheadTime / animLength;
  
  //maipulate 'p'
 // p = 1 - (1-p)*(1-p);//bends curve down -ease in
   p = p *p *(3-2*p);//smooth step
  
  float x = lerp(valStart, valEnd, p);
  ellipse(x, height/2.0, 20, 20);
}

void mousePressed()
{
  animPlayheadTime = 0; //restarts the animation
  isTweenPlaying = true;
  
}
