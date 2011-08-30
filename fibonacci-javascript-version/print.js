var counter = 0;

//This is a Fibonacci printer!
function print(message){
	equal( message, f(counter), "expected " + f(counter) + " and got " + message );
    counter++;
}

function f(n){
	var result = 0;
	if (n == 0) return result;
	if (n == 1) { return ++result; }
	else {
		return f(n-1) + f(n-2);
	}
}