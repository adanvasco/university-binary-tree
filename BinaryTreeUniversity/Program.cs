using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            //The objects that are needed are created
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector Financiero";
            vicFinPosition.Salary = 750;
                      
            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria Financiera 1";
            secFin1Position.Salary = 350;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria Financiera 2";
            secFin2Position.Salary = 310;

            Position vicAcademicoPosition = new Position();
            vicAcademicoPosition.Name = "Vicerector Academico";
            vicAcademicoPosition.Salary = 780;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe de registro Academico";
            jefeRegPosition.Salary = 640;

            Position secGen2Position = new Position();
            secGen2Position.Name = "Secretaria General 2";
            secGen2Position.Salary = 360;

            Position secGen1Position = new Position();
            secGen1Position.Name = "Secretaria General 1";
            secGen1Position.Salary = 400;

            Position asistente2Position = new Position();
            asistente2Position.Name = "Asistente 2";
            asistente2Position.Salary = 170;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;

            Position asistente1Position = new Position();
            asistente1Position.Name = "Asistente 1";
            asistente1Position.Salary = 250;

            //Create the university tree, creating positions
            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            
            universityTree.CreatePosition(universityTree.Root, vicAcademicoPosition, rectorPosition.Name);
            
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcademicoPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secGen2Position, jefeRegPosition.Name);
            
            universityTree.CreatePosition(universityTree.Root, secGen1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asistente2Position, secGen1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asistente2Position.Name);
           
            universityTree.CreatePosition(universityTree.Root, asistente1Position, secGen1Position.Name);
                        
            universityTree.PrintTree(universityTree.Root);
            
            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"\nTotal Saly: {totalSalary}");  

            Console.ReadLine();
        }
    }
}