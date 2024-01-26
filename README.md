This project is entry and exit automation.
This can be used in places such as cafe, bars. An application that employees will use when entering and exiting work.
In order to use this application, employees must determine their 4-digit password from the registration tab.
After determining, they can log in and out using their password.
This application also has a database section. User information and entry and exit times are specified in the database.

In the code shown below, you must write the name of your computer in the "Data Source = " section. You will see this name after setting up the database.
conn = new SqlConnection(@"Data Source=your_pc_name;Initial Catalog=EEE;Integrated Security=True");
