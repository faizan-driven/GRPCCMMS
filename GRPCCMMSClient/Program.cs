// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GRPCCMMSClient;
using Microsoft.AspNetCore.Mvc;



var httpHandler = new HttpClientHandler
{
    ServerCertificateCustomValidationCallback =
            HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
};

//using var channel = GrpcChannel.ForAddress("http://localhost:5153"); 
using var channel = GrpcChannel.ForAddress("http://206.208.222.116:9999",
    new GrpcChannelOptions { HttpHandler = httpHandler });
// Here Create Variable Channel For Stored Client (LocalHost Address) Service End Point.
//using var Server = CMMS.CMMSClient.ForAddress()
var client = new CMMS.CMMSClient(channel);
// And Create Variable Client For Communication Server To Client.

////Console.WriteLine("Hello, World!");
//using var Channel = GrpcChannel.ForAddress("https://206.208.222.116:9999");
////using var Channel = GrpcChannel.ForAddress("CG4L/l21ElabK9QvDjw3R6weJ1RQhdZ2zhZZqFHL/A4=");
//var client = new CMMS.CMMSClient(Channel);
////[HttpGet(template:"secret")]
///

var GetVersion = client.GetVersion(new VersionRequest
{

});

var GetAllEquipment = client.GetAllEquipment(new AllEquipmentRequest { });

var GetEquipment = client.GetEquipment(
    new EquipmentRequest { Id = "" });

var AddOrUpdateEquipment = client.AddOrUpdateEquipment(
    new Equipment
    {
        Id = "",
        Name = "",
        ShortName = "",
        Notes = "",
        Manufacturer = "",
        Model = "",
        Owner = "",
        SerialNumber = "",
        FixedAssetNumber = "",
        SecondaryFixedAssetNumber = "",
        //Capital_equipment = true,
        DepreciationDate = "",
        ExpirationDate = "",
        PlacedInServiceDate = "",
        Value = 0,

    });
Console.WriteLine(AddOrUpdateEquipment.Message);

var SynchronizeEquipment = client.SynchronizeEquipment(new Grpc.Core.Metadata { });

var GetAllSensors = client.GetAllSensors(new AllSensorsRequest { Provider = "" });

var GetSensor = client.GetSensor(new SensorRequest { Label = "", Provider = "" });

var GetAllLocations = client.GetAllLocations(new AllLocationsRequest { WithKey = true });

var GetLocation = client.GetLocation(new LocationRequest { Id = "", Key = "" });

var GetAllEquipmentUseStatuses = client.GetAllEquipmentUseStatuses(new AllEquipmentUseStatusesRequest
{

});

var GetEquipmentUseStatusChanges = client.GetEquipmentUseStatusChanges(new EquipmentUseStatusChangesRequest
{

});

var GetEquipmentLocationChanges = client.GetEquipmentLocationChanges(new EquipmentLocationChangesRequest
{

});

var GetEquipmentMap = client.GetEquipmentMap(new EquipmentMapRequest
{

});

var GetAllEquipmentTypes = client.GetAllEquipmentTypes(new AllEquipmentTypesRequest
{

});


var GetEquipmentType = client.GetEquipmentType(new EquipmentTypeRequest
{
    Name = "",
});