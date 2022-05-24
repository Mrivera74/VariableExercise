//Declared Variables
string dogName;
int dogAge;
char dogPic;
bool purebreed;
double dogHeight;
decimal dogWeight;

//Initialized Variables
dogName = "Chino";
dogAge = 10;
dogPic = 'a';
purebreed = true;
dogHeight = 24.3;
dogWeight = 50.3m;

Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old, he is {dogHeight} inches tall and weights {dogWeight}lbs. It is {purebreed} that my dog is a purebreed. If your would like to see the dog pictures select a, if not select b. {dogPic}");

//Interpolerize Variables
string dogsName = "Chino";
int dogsAge = 10;
char dogsPic = 'a';
bool breedOfDog = true;
double dogsHeight = 24.3;
decimal dogsWeight = 50.3m;

Console.WriteLine($"My dog's name is {dogsName}. He is {dogsAge} years old, he is {dogsHeight} inches tall and weights {dogsWeight}lbs. It is {breedOfDog} that my dog is a purebreed. If your would like to see the dog pictures select a, if not select b. {dogsPic}");

