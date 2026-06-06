﻿var slot = new ParkingSlot("A-101");
slot.Park("DHAKA-1234");

Console.WriteLine(slot.IsOccupied);     // True
Console.WriteLine(slot.VehicleNumber);  // DHAKA-1234

string vehicleNumber = slot.Unpark();

Console.WriteLine(slot.IsOccupied);     // False
Console.WriteLine(slot.VehicleNumber);  // null
Console.WriteLine(vehicleNumber);  // DHAKA-1234