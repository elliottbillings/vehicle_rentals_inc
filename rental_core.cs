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
        public int Client_ID;

    };

    //Bookings Structure initiator

    enum booking_state {Pending, Approved, In_Progress, Cancelled}

    struct Booking
    {
        public booking_state State;
        public int Client_ID;
        public int Vehicle_ID;
        //public string
    }


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
        //General purpose methods

        static string menu_input_sanity_check(string input)
        {
            int input_int;
            bool check = false;
            
            while (check == false)
            {
                input = Console.ReadLine();
                try
                {
                    //TODO: Increase validity parameters, i.e force len 1.
                    input_int = int.Parse(input);
                    check = true;           
                }
                catch
                {
                    check = false;
                    Console.WriteLine("Invalid input, please try again");
                    continue;
                }
            }

            return input;
        }

        //View Records Menu
            //Display all records, specific records filter search?

        static void view_records_menu()
        {
           
        }

        //Manage Records Menu
            //Functionality for modifying existing or adding new records.

        static void manage_records_menu()
        {

        }

        //Pending

        //Commit changes to file
        static void commit_to_file()
        {

        }


        static void Main()
        {

            //global vars
            const int max_clients = 20;
            const int max_vehicles = 5;

            string selection_s = "0";
            int selection;

            bool quit = false;

            //Inititate Arrays
            Client[] Clients = new Client[max_clients];
            Vehicle[] Vehicles = new Vehicle[max_vehicles];


            //Master Menu Loop
            while(quit == false)
            {
                Console.WriteLine("Main Menu: ");
                Console.WriteLine("1 - View Records");
                Console.WriteLine("2 - Manage Records");
                Console.WriteLine("3 - Pending");
                Console.WriteLine("4 - Save Changes to File");
                Console.WriteLine("5 - Quit");
                Console.WriteLine("Enter selection: ");

                selection_s = menu_input_sanity_check(selection_s);

                selection = Convert.ToInt32(selection_s);

                Console.Clear();

                switch (selection)
                {
                    case 1: // View 
                        Console.WriteLine("1 - View Records");
                        break;
                    case 2: //
                        Console.WriteLine("2 - Manage Records");
                        break;
                    case 3: //
                        Console.WriteLine("3 - Pending");
                        break;
                    case 4:  //
                        Console.WriteLine("4 - Save Changes to File");
                        break;
                    case 5: //Quit
                        Console.WriteLine("Program Exit: Goodbye");
                        quit = true;
                        break;
                }
                

            }

            Console.WriteLine("Program Exit: Goodbye");
            
        }
    }
}
