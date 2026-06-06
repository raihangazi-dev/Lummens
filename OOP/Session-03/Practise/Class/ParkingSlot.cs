public class ParkingSlot
{
    public string SlotId { get; private set; }
    public string? VehicleNumber { get; private set; }
    public bool IsOccupied { get; private set; }

    public ParkingSlot(string slotId)
    {
        if (string.IsNullOrWhiteSpace(slotId))
            throw new ArgumentException("Slot id is required.");

        SlotId = slotId;
        VehicleNumber = null;
        IsOccupied = false;
    }

    public void Park(string vehicleNumber)
    {
        if (IsOccupied)
            throw new InvalidOperationException("Slot is already occupied.");

        if (string.IsNullOrWhiteSpace(vehicleNumber))
            throw new ArgumentException("Vehicle number is required.");

        VehicleNumber = vehicleNumber;
        IsOccupied = true;
    }

    public string Unpark()
    {
        if (!IsOccupied)
            throw new InvalidOperationException("Slot is already empty.");

        string vehicleNumber = VehicleNumber!;
        VehicleNumber = null;
        IsOccupied = false;
        return vehicleNumber;
    }
}