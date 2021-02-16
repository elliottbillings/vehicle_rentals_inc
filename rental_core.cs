using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16/02/2021 - Elliott Billings
//objective: create a vehicle rental management system
//current scope outlines:
//allow users to add, modify, and remove records.
//store customer records and vehicle inventory and their relations and or states, i.e customer A is using Van B etc.
// example starter params, 20 customers and 5 vehicles (we are just starting out).
// and some kind of booking system

//read and store records to local csv files
//


namespace vehicle_rentals_inc
{
    //Client Structure initiator
    enum client_account_state { New, Active, Issue_Flagged, Closed}
    enum client_type { Business, Private}
    struct Client
    {
        public client_account_state State;
        public client_type Type;
        public string F_Name;
        public string S_Name;
        public string D_Licence;
        public string Address;
        public int A_Number;

    };

    //Vehicle Structure initiator

    enum vehicle_state { Available, Booked, In_Use, Out_Of_Service}
    enum vehicle_type { Coupe, Saloon, Estate, Van, Pickup, Motorbike}
    struct Vehicle
    {
        public vehicle_state State;
        public vehicle_type Type;
        public string L_plate;
        public string MOT_Date;
        public int Vehicle_ID;
    };

    class rental_core
    {
        //View Records Menu
            //Display all records, specific records filter search?

        //Manage Records Menu
            //

        //

        //


        static void Main()
        {

            //global vars
            const int max_clients = 20;
            const int max_vehicles = 5;

            bool quit = false;

            //Inititate Arrays
            Client[] Clients = new Client[max_clients];
            Vehicle[] Vehicles = new Vehicle[max_vehicles];


            //Master Menu Loop
            while(quit == false)
            {
                string selection_s;
                int selection_i;

                //display menu list and prompt

                Console.WriteLine("Main Menu: ");
                Console.WriteLine("1 - View Records");
                Console.WriteLine("2 - Manage Records");
                Console.WriteLine("3 - Pending");
                Console.WriteLine("4 - Save Changes to File");
                Console.WriteLine("5 - Quit");
                Console.WriteLine("Enter selection: ");

                selection_s = Console.ReadLine();

                try
                {
                    selection_i = int.Parse(selection_s); //improve sanity check
                }

                catch
                {
                    Console.WriteLine("Invalid Menu Option");
                    Console.WriteLine("===================");
                    continue;
                }

                selection_i = Convert.ToInt32(selection_s);

                Console.Clear();

                switch (selection_i)
                {
                    case 1: // View 
                        Console.WriteLine("===");
                        break;
                    case 2: //
                        Console.WriteLine("===");
                        break;
                    case 3: //
                        Console.WriteLine("===");
                        break;
                    case 4:  //
                        Console.WriteLine("===");
                        break;
                    case 5: //Quit
                        Console.WriteLine("Program Exit: Goodbye");
                        quit = true;
                        break;
                }



            }
        
            

            



        }
    }
}
