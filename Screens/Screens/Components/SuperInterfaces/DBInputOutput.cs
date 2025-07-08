using System;
using System.Data;

namespace Screens.Components.SuperInterfaces
{
    interface DBInputOutput
    {
        void Insert(); // Method for Inserting/ Storing Data into Databse.

        void Update(); // Method for Updating data in Database.

        DataTable Display(); // Method for Displaying data from Database in tabular data.
    }
}
