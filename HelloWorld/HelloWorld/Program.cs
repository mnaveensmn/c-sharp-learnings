using System;
using HelloWorld.O01_Variable;
using HelloWorld.O02_Class;
using HelloWorld.O03_Array;
using HelloWorld.O04_String;
using HelloWorld.O05_Enum;
using HelloWorld.O06_ReferenceValueType;
using HelloWorld.O07_ControlFlow;

namespace HelloWorld
{
    class Program
    {
        public static void LearnVariables()
        {
            Variables.Initialize();
            Variables.Overflowing();
            Variables.TypeConversion();
        }

        public static void LearnClasses()
        {
            Person person = new("Naveen", "Kumar");
            person.Introduce();
        }

        public static void LearnArray()
        {
            ArrayDemo.ArrayExample();
        }

        public static void LearnEnum()
        {
            EnumLearnings.Learn();
        }

        public static void LearnString()
        {
            StringLearnings.Learn();
        }

        public static void LearnReferenceValueType()
        {
            ReferenceValueType.Learn();
        }

        public static void LearnControlFlow()
        {
            ControlFlow.LearnIfElse();
            ControlFlow.LearnSwitch();
        }

        static void Main(string[] args)
        {
            LearnVariables();
            LearnClasses();
            LearnArray();
            LearnEnum();
            LearnString();
            LearnReferenceValueType();
            LearnControlFlow();
        }
    }
}
