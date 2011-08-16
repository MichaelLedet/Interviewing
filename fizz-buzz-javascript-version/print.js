var counter = 1;

//This is a FizzBuzz printer!
function print(message){
    if (counter % 3 === 0 && counter % 5 === 0)
        equal( message, "FizzBuzz", "expected FizzBuzz and got " + message );    
    else if (counter % 3 === 0)
        equal( message, "Fizz", "expected Fizz and got " + message );    
    else if (counter % 5 === 0)
        equal( message, "Buzz", "expected Buzz and got " + message );    
    else
        equal( message, counter, "expected " + counter + " and got " + message );
    counter++;
}