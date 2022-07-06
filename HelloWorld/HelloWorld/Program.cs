using System;
using HelloWorld.O00_Exercise;
using HelloWorld.O01_Variable;
using HelloWorld.O02_Class;
using HelloWorld.O03_Array;
using HelloWorld.O04_String;
using HelloWorld.O05_Enum;
using HelloWorld.O06_ReferenceValueType;
using HelloWorld.O07_ControlFlow;
using HelloWorld.O08_ArrayAndList;
using HelloWorld.O09_Dates;

namespace HelloWorld
{
    enum Learning
    {
        Variables,
        Classes,
        Array,
        Enum,
        String,
        ReferenceValueType,
        ControlFlow,
        ArrayAndList,
        DateTime,

        ExerciseControlFlow,
        ExerciseLoops,
        ExerciseArrayAndList
    };

    class Program
    {
        public static void Execute(Learning learning)
        {
            switch (learning)
            {
                case Learning.Array:
                    ArrayDemo.ArrayExample();
                    break;
                case Learning.ArrayAndList:
                    ArrayAndList.Learn();
                    break;
                case Learning.Classes:
                    Person person = new("Naveen", "Kumar");
                    person.Introduce();
                    break;
                case Learning.ControlFlow:
                    ControlFlow.Learn();
                    break;
                case Learning.Enum:
                    EnumLearnings.Learn();
                    break;
                case Learning.ExerciseArrayAndList:
                    O03_ArrayAndList.Run();
                    break;
                case Learning.ExerciseControlFlow:
                    O01_ControlFlow.Run();
                    break;
                case Learning.ExerciseLoops:
                    O02_Loops.Run();
                    break;
                case Learning.ReferenceValueType:
                    ReferenceValueType.Learn();
                    break;
                case Learning.String:
                    StringLearnings.Learn();
                    break;
                case Learning.Variables:
                    Variables.Learn();
                    break;
                case Learning.DateTime:
                    DateAndTimes.Learn();
                    break;
                default:
                    Console.WriteLine("No Program is configured");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Execute(Learning.DateTime);
        }
    }
}
