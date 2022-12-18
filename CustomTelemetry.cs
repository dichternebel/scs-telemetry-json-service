using System;
using System.Collections.Generic;

namespace TelemetryJsonService
{

    // CustomTelemetry myDeserializedClass = JsonConvert.DeserializeObject<CustomTelemetry>(myJsonResponse);
    public class AccelerationValues
    {
        public AngularAcceleration AngularAcceleration { get; set; }
        public AngularVelocity AngularVelocity { get; set; }
        public LinearAcceleration LinearAcceleration { get; set; }
        public LinearVelocity LinearVelocity { get; set; }
        public CabinAngularVelocity CabinAngularVelocity { get; set; }
        public CabinAngularAcceleration CabinAngularAcceleration { get; set; }
    }

    public class AngularAcceleration
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class AngularVelocity
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class BrakeValues
    {
        public int RetarderLevel { get; set; }
        public double AirPressure { get; set; }
        public double Temperature { get; set; }
        public bool ParkingBrake { get; set; }
        public bool MotorBrake { get; set; }
    }

    public class Cabin
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class CabinAngularAcceleration
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class CabinAngularVelocity
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class CabinOffset
    {
        public Position Position { get; set; }
        public Orientation Orientation { get; set; }
    }

    public class CabinPositionInWorlSpace
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class CapacityValues
    {
        public double Fuel { get; set; }
        public double AdBlue { get; set; }
    }

    public class CargoValues
    {
        public double Mass { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int UnitCount { get; set; }
        public double UnitMass { get; set; }
        public double CargoDamage { get; set; }
    }

    public class CommonValues
    {
        public GameTime GameTime { get; set; }
        public NextRestStop NextRestStop { get; set; }
        public NextRestStopTime NextRestStopTime { get; set; }
        public double Scale { get; set; }
    }

    public class ConstantsValues
    {
        public MotorValues MotorValues { get; set; }
        public CapacityValues CapacityValues { get; set; }
        public WarningFactorValues WarningFactorValues { get; set; }
        public WheelsValues WheelsValues { get; set; }
        public string BrandId { get; set; }
        public string Brand { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public string LicensePlateCountryId { get; set; }
        public string LicensePlateCountry { get; set; }
    }

    public class ControlValues
    {
        public InputValues InputValues { get; set; }
        public GameValues GameValues { get; set; }
    }

    public class CruiseControlSpeed
    {
        public double Value { get; set; }
        public double Kph { get; set; }
        public double Mph { get; set; }
    }

    public class CurrentValues
    {
        public bool ElectricEnabled { get; set; }
        public bool EngineEnabled { get; set; }
        public bool DifferentialLock { get; set; }
        public bool LiftAxle { get; set; }
        public bool LiftAxleIndicator { get; set; }
        public bool TrailerLiftAxle { get; set; }
        public bool TrailerLiftAxleIndicator { get; set; }
        public MotorValues MotorValues { get; set; }
        public DashboardValues DashboardValues { get; set; }
        public LightsValues LightsValues { get; set; }
        public WheelsValues WheelsValues { get; set; }
        public DamageValues DamageValues { get; set; }
        public AccelerationValues AccelerationValues { get; set; }
        public PositionValue PositionValue { get; set; }
    }

    public class DamageValues
    {
        public double Body { get; set; }
        public double Cargo { get; set; }
        public double Chassis { get; set; }
        public double Wheels { get; set; }
        public double Engine { get; set; }
        public double Transmission { get; set; }
        public double Cabin { get; set; }
        public double WheelsAvg { get; set; }
    }

    public class DashboardValues
    {
        public FuelValue FuelValue { get; set; }
        public WarningValues WarningValues { get; set; }
        public int GearDashboards { get; set; }
        public Speed Speed { get; set; }
        public CruiseControlSpeed CruiseControlSpeed { get; set; }
        public double AdBlue { get; set; }
        public double OilPressure { get; set; }
        public double OilTemperature { get; set; }
        public double WaterTemperature { get; set; }
        public double BatteryVoltage { get; set; }
        public double RPM { get; set; }
        public double Odometer { get; set; }
        public bool Wipers { get; set; }
        public bool CruiseControl { get; set; }
    }

    public class DeliveryTime
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class FerryEvent
    {
        public int PayAmount { get; set; }
        public string SourceId { get; set; }
        public string SourceName { get; set; }
        public string TargetId { get; set; }
        public string TargetName { get; set; }
    }

    public class FinedEvent
    {
        public int Amount { get; set; }
        public int Offence { get; set; }
    }

    public class Finished
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class FuelValue
    {
        public double Amount { get; set; }
        public double AverageConsumption { get; set; }
        public double Range { get; set; }
    }

    public class GamePlay
    {
        public FerryEvent FerryEvent { get; set; }
        public FinedEvent FinedEvent { get; set; }
        public JobCancelled JobCancelled { get; set; }
        public JobDelivered JobDelivered { get; set; }
        public TollgateEvent TollgateEvent { get; set; }
        public TrainEvent TrainEvent { get; set; }
        public RefuelEvent RefuelEvent { get; set; }
    }

    public class GameTime
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class GameValues
    {
        public double Steering { get; set; }
        public double Throttle { get; set; }
        public double Brake { get; set; }
        public double Clutch { get; set; }
    }

    public class GameVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
    }

    public class GearValues
    {
        public int HShifterSlot { get; set; }
        public int Selected { get; set; }
        public List<bool> HShifterSelector { get; set; }
    }

    public class Head
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class HeadOffset
    {
        public Position Position { get; set; }
        public Orientation Orientation { get; set; }
    }

    public class HeadPositionInCabinSpace
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class HeadPositionInVehicleSpace
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class HeadPositionInWorldSpace
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class Hook
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class HookPositionInWorldSpace
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class InputValues
    {
        public double Steering { get; set; }
        public double Throttle { get; set; }
        public double Brake { get; set; }
        public double Clutch { get; set; }
    }

    public class JobCancelled
    {
        public int Penalty { get; set; }
        public Finished Finished { get; set; }
        public Started Started { get; set; }
    }

    public class JobDelivered
    {
        public bool AutoLoaded { get; set; }
        public bool AutoParked { get; set; }
        public double CargoDamage { get; set; }
        public DeliveryTime DeliveryTime { get; set; }
        public double DistanceKm { get; set; }
        public int EarnedXp { get; set; }
        public int Revenue { get; set; }
        public Finished Finished { get; set; }
        public Started Started { get; set; }
        public StartedBackup StartedBackup { get; set; }
    }

    public class JobValues
    {
        public DeliveryTime DeliveryTime { get; set; }
        public RemainingDeliveryTime RemainingDeliveryTime { get; set; }
        public bool CargoLoaded { get; set; }
        public bool SpecialJob { get; set; }
        public int Market { get; set; }
        public int PlannedDistanceKm { get; set; }
        public CargoValues CargoValues { get; set; }
        public string CityDestinationId { get; set; }
        public string CityDestination { get; set; }
        public string CompanyDestinationId { get; set; }
        public string CompanyDestination { get; set; }
        public string CitySourceId { get; set; }
        public string CitySource { get; set; }
        public string CompanySourceId { get; set; }
        public string CompanySource { get; set; }
        public int Income { get; set; }
    }

    public class LightsValues
    {
        public int AuxFront { get; set; }
        public int AuxRoof { get; set; }
        public double DashboardBacklight { get; set; }
        public bool BlinkerLeftActive { get; set; }
        public bool BlinkerLeftOn { get; set; }
        public bool BlinkerRightActive { get; set; }
        public bool BlinkerRightOn { get; set; }
        public bool Parking { get; set; }
        public bool BeamLow { get; set; }
        public bool BeamHigh { get; set; }
        public bool Beacon { get; set; }
        public bool Brake { get; set; }
        public bool Reverse { get; set; }
        public bool HazardWarningLights { get; set; }
    }

    public class LinearAcceleration
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class LinearVelocity
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class MotorValues
    {
        public int ForwardGearCount { get; set; }
        public int ReverseGearCount { get; set; }
        public int RetarderStepCount { get; set; }
        public int SelectorCount { get; set; }
        public List<int> SlotGear { get; set; }
        public List<int> SlotHandlePosition { get; set; }
        public List<int> SlotSelectors { get; set; }
        public double EngineRpmMax { get; set; }
        public double DifferentialRation { get; set; }
        public List<double> GearRatiosForward { get; set; }
        public List<double> GearRatiosReverse { get; set; }
        public int ShifterTypeValue { get; set; }
        public GearValues GearValues { get; set; }
        public BrakeValues BrakeValues { get; set; }
    }

    public class NavigationValues
    {
        public double NavigationDistance { get; set; }
        public double NavigationTime { get; set; }
        public SpeedLimit SpeedLimit { get; set; }
    }

    public class NextRestStop
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class NextRestStopTime
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class Orientation
    {
        public double Heading { get; set; }
        public double Pitch { get; set; }
        public double Roll { get; set; }
    }

    public class Position
    {
        public Position position { get; set; }
        public Orientation Orientation { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class Positioning
    {
        public Cabin Cabin { get; set; }
        public Head Head { get; set; }
        public Hook Hook { get; set; }
        public HeadOffset HeadOffset { get; set; }
        public CabinOffset CabinOffset { get; set; }
        public HeadPositionInCabinSpace HeadPositionInCabinSpace { get; set; }
        public HeadPositionInVehicleSpace HeadPositionInVehicleSpace { get; set; }
        public HeadPositionInWorldSpace HeadPositionInWorldSpace { get; set; }
        public CabinPositionInWorlSpace CabinPositionInWorlSpace { get; set; }
        public HookPositionInWorldSpace HookPositionInWorldSpace { get; set; }
    }

    public class PositionValue
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class PositionValue3
    {
        public Position Position { get; set; }
        public Orientation Orientation { get; set; }
    }

    public class RefuelEvent
    {
        public double Amount { get; set; }
    }

    public class RemainingDeliveryTime
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class CustomTelemetry
    {
        public CommonValues CommonValues { get; set; }
        public ControlValues ControlValues { get; set; }
        public int DllVersion { get; set; }
        public string Game { get; set; }
        public GamePlay GamePlay { get; set; }
        public GameVersion GameVersion { get; set; }
        public JobValues JobValues { get; set; }
        public int MaxTrailerCount { get; set; }
        public int MultiplayerTimeOffset { get; set; }
        public NavigationValues NavigationValues { get; set; }
        public bool Paused { get; set; }
        public int RenderTimestamp { get; set; }
        public bool SdkActive { get; set; }
        public int SimulationTimestamp { get; set; }
        public SpecialEventsValues SpecialEventsValues { get; set; }
        public List<object> Substances { get; set; }
        public TelemetryVersion TelemetryVersion { get; set; }
        public int Timestamp { get; set; }
        public List<TrailerValue> TrailerValues { get; set; }
        public TruckValues TruckValues { get; set; }
    }

    public class SpecialEventsValues
    {
        public bool OnJob { get; set; }
        public bool JobFinished { get; set; }
        public bool JobCancelled { get; set; }
        public bool JobDelivered { get; set; }
        public bool Fined { get; set; }
        public bool Tollgate { get; set; }
        public bool Ferry { get; set; }
        public bool Train { get; set; }
        public bool Refuel { get; set; }
        public bool RefuelPayed { get; set; }
    }

    public class Speed
    {
        public double Value { get; set; }
        public double Kph { get; set; }
        public double Mph { get; set; }
    }

    public class SpeedLimit
    {
        public double Value { get; set; }
        public double Kph { get; set; }
        public double Mph { get; set; }
    }

    public class Started
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class StartedBackup
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class TelemetryVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
    }

    public class TollgateEvent
    {
        public int PayAmount { get; set; }
    }

    public class TrailerValue
    {
        public AccelerationValues AccelerationValues { get; set; }
        public bool Attached { get; set; }
        public string BodyType { get; set; }
        public string Brand { get; set; }
        public string BrandId { get; set; }
        public string CargoAccessoryId { get; set; }
        public string ChainType { get; set; }
        public DamageValues DamageValues { get; set; }
        public Hook Hook { get; set; }
        public string Id { get; set; }
        public string LicensePlate { get; set; }
        public string LicensePlateCountry { get; set; }
        public string LicensePlateCountryId { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public WheelsConstant WheelsConstant { get; set; }
        public Wheelvalues Wheelvalues { get; set; }
    }

    public class TrainEvent
    {
        public int PayAmount { get; set; }
        public string SourceId { get; set; }
        public string SourceName { get; set; }
        public string TargetId { get; set; }
        public string TargetName { get; set; }
    }

    public class TruckValues
    {
        public ConstantsValues ConstantsValues { get; set; }
        public CurrentValues CurrentValues { get; set; }
        public Positioning Positioning { get; set; }
    }

    public class WarningFactorValues
    {
        public double Fuel { get; set; }
        public double AdBlue { get; set; }
        public double AirPressure { get; set; }
        public double AirPressureEmergency { get; set; }
        public double OilPressure { get; set; }
        public double WaterTemperature { get; set; }
        public double BatteryVoltage { get; set; }
    }

    public class WarningValues
    {
        public bool AirPressure { get; set; }
        public bool AirPressureEmergency { get; set; }
        public bool FuelW { get; set; }
        public bool AdBlue { get; set; }
        public bool OilPressure { get; set; }
        public bool WaterTemperature { get; set; }
        public bool BatteryVoltage { get; set; }
    }

    public class WheelsConstant
    {
        public int Count { get; set; }
        public List<double> Radius { get; set; }
        public List<bool> Simulated { get; set; }
        public List<bool> Powered { get; set; }
        public List<bool> Liftable { get; set; }
        public List<bool> Steerable { get; set; }
        public List<PositionValue> PositionValues { get; set; }
    }

    public class WheelsValues
    {
        public int Count { get; set; }
        public List<double> Radius { get; set; }
        public List<bool> Simulated { get; set; }
        public List<bool> Powered { get; set; }
        public List<bool> Liftable { get; set; }
        public List<bool> Steerable { get; set; }
        public List<PositionValue> PositionValues { get; set; }
        public List<int> Substance { get; set; }
        public List<double> SuspDeflection { get; set; }
        public List<double> Velocity { get; set; }
        public List<double> Steering { get; set; }
        public List<double> Rotation { get; set; }
        public List<double> Lift { get; set; }
        public List<double> LiftOffset { get; set; }
        public List<bool> OnGround { get; set; }
    }

    public class Wheelvalues
    {
        public List<double> Lift { get; set; }
        public List<double> LiftOffset { get; set; }
        public List<bool> OnGround { get; set; }
        public List<double> Rotation { get; set; }
        public List<double> Steering { get; set; }
        public List<int> Substance { get; set; }
        public List<double> SuspDeflection { get; set; }
        public List<double> Velocity { get; set; }
    }
}
