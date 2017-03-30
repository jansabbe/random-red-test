# random-red-test

When you run all the tests, they might 

* all succeed
* one test might fail with an `NSubstitute.Exceptions.ReceivedCallsException : Expected to receive a call matching` exception
* another test might fail with an `NSubstitute.Exceptions.AmbiguousArgumentsException : Cannot determine argument specifications to use`

Can you find the real faulty test?