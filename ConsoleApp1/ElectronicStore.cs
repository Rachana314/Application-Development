using System;
using System.Collections.Generic;

public class ElectronicsStore
{
    private List<ElectronicDevice> devices;

    public ElectronicsStore()
    {
        devices = new List<ElectronicDevice>();
    }

    // Add device to the store
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to the store.");
    }

    // Remove device from the store
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
        {
            Console.WriteLine($"{device.Brand} removed from the store.");
        }
        else
        {
            Console.WriteLine($"{device.Brand} not found in the store.");
        }
    }

    // Display details of all devices
    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("---- Devices in Store ----");
        foreach (var device in devices)
        {
            device.ShowInfo(); // call abstract method

            // Downcasting to call child-specific methods
            if (device is Laptop lap)
            {
                lap.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine(); // extra line for readability
        }
    }
}