/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods


{
    class Program
    {
        /* A method performs an action in a series of statements. A method can receive
        input data from the caller by specifying parameters and output data back to the caller
        by specifying a return type. A method can specify a void return type, indicating that
        it doesn't return any value to its caller. A method can also input data back to the 
        caller via ref/out parameters. */
        /* A method's signature must be uniqe with the type. A method's signature comprises
        its name and parameter types in order (but not the parameter names, nor the return
        type. */
        /* Methods allow the following modifiers:
        Static modifier:             static
        Access modifiers:            public, internal, private, protected
        Inheritance Modifiers:       new, virtual, abstract, override, sealed
        Partial Method Modifier:     partial
        Unmanaged code Modifiers:    unsafe extern
        Asychronous code Modifier:   Async   */
        // Expression-bodied methods:
        // A method that comprises a single expression, such as the following:
        int Foo(int x) { return x * 2; }
        /* Can be written more tersely as an expression-bodied method. A fat arrow replaces
         the braces and return keyword: */
        int Foo2(int x) => x * 2;
        // Expression-bodied functions can also have a void return type:
        void Foo3(int x) => Console.WriteLine(x);
        // OVERLOADING METHODS
        /* A type overload methods (have multiple methods with the same), as long as the 
         signatures are different. For example, the following methods can all coexist in 
         the same type: */
        void Foo (double x) { }
        void Foo (int x, float y ) { }
        void Foo (float x, int y) { }
        /* However, the following pairs of methods cannot coexist in the same type, since
         the return type and the params modifier are not part of a method's signature: */
        // float Foo (int x) {}     // Compile-time error
        void Goo (int[] x) { }
        //void Goo(params int[] x) { } //Compile-time error
        // PASS-BY-VALUE VERSUS PASS-BY-REFERENCE
        /*Whether a parameter is pass-by-value or pass-by-reference is also part of the 
         signature. For example, Foo(int) can coexist with either Foo(ref int) or
         Foo (out int). However, Foo(ref int) and Foo(out int) cannot coexist: */
        void Foo (ref int x) { }   // OK so far
        // void Foo (out int x) {} // Compile-time error 
        static void Main()
        {
            
        }
    }
}
