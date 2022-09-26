

using AbstractClassesLesson;

var myTank = new Tank(); // this is a tank specifically but it behaves like a vehicle 
myTank.Drive();
myTank.Reverse();
myTank.Operate(); // if we call Tanks Operate it is going to use what is in tank because we wrote stuff
                    // in its scope.  

var mustang = new Mustang();
mustang.Operate();  // if you go look at the mustang class we never defined Operate but it shows up
                    // once you type .  because it is in the vehicle class.  