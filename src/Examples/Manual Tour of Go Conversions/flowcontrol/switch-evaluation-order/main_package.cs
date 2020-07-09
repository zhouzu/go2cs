﻿/*
package main

import (
	"fmt"
	"time"
)

func main() {
	fmt.Println("When's Saturday?")
	today := time.Now().Weekday()
	switch time.Saturday {
	case today + 0:
		fmt.Println("Today.")
	case today + 1:
		fmt.Println("Tomorrow.")
	case today + 2:
		fmt.Println("In two days.")
	default:
		fmt.Println("Too far away.")
	}
}
*/

using go;
using fmt = go.fmt_package;
using time = go.time_package;

static class main_package
{
    static void Main() {
		fmt.Println("When's Saturday?");
		var today = time.Now().Weekday();

        // Option 1: - this would not be able to handle fallthrough
        //switch (true) {
        //	  case true when time.Saturday == today + 0:
        //		  fmt.Println("Today.");
        //		  break;
        //    case true when time.Saturday == today + 1:
        //        fmt.Println("Tomorrow.");
        //        break;
        //    case true when time.Saturday == today + 2:
        //        fmt.Println("In two days.");
        //        break;
        //    default:
        //		  fmt.Println("Too far away.");
        //		  break;
        //}

        // Option 2: - handles fallthrough with "if" instead of "else if"
        if (time.Saturday == today + 0) {
            fmt.Println("Today.");
        }
        else if (time.Saturday == today + 1) {
            fmt.Println("Tomorrow.");
        }
        else if (time.Saturday == today + 2) {
            fmt.Println("In two days.");
        }
        else {
            fmt.Println("Too far away.");
        }

        // Possible Option 3 with C# 9.0 - how to handle fallthrough?
        //time.Saturday switch
        //{
        //    == today + 0 => fmt.Println("Today.");
        //    == today + 1 => fmt.Println("Tomorrow.");
        //    == today + 2 => fmt.Println("In two days.");
        //	  _ => fmt.Println("Too far away.");
        //};
    }
}
