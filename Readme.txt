Order to run files to create tables and insert data:
1. Tables
2. TeamData
3. TeamTypeData
4. PlayerData
5. GameData
6. TeamGameData
7. PlayerStatsData

At the top of each data file (except TeamTypeData) is code that allows the user to import the data 
using the wizard provided in SSMS:
1. Right click on the desired DB
2. Tasks -> Import flat file
3. Browse for the csv file to import (follow the order outlined earlier)
4. Keep table name and everything else the same -- as the wizard automatically fills in
5. Click next all the way through -- do not change anything
6. Run the code at the top of the corresponding file. For example, if you are importing the TeamDataExc.csv file,
   then following doing that, run the four lines of code at the top of TeamData.sql