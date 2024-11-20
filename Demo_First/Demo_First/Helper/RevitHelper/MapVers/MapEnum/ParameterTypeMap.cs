﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_First
{
    public enum ParameterTypeMap
    {
        // Invalid,//The parameter type is invalid. This value should not be used.
        Text,//The parameter data should be interpreted as a string of text.
        Integer,//The parameter data should be interpreted as a whole number, positive or negative.
        Number,//The parameter data should be interpreted as a real number, possibly including decimal points.
        Length,//The parameter data represents a length.
        Area,//The parameter data represents an area.
        Volume,//The parameter data represents a volume.
        Angle,//The parameter data represents an angle.
        URL,//A text string that represents a web address.
        Material,//The value of this property is considered to be a material.
        YesNo,//A boolean value that will be represented as Yes or No.
        Force,//The data value will be represented as a force.
        LinearForce,//The data value will be represented as a linear force.
        AreaForce,//The data value will be represented as an area force.
        Moment,//The data value will be represented as a moment.
        NumberOfPoles,//A parameter value that represents the number of poles, as used in electrical disciplines.
        FixtureUnit,//A parameter value that represents the fixture units, as used in piping disciplines.
        FamilyType,//A parameter used to control the type of a family nested within another family.
        LoadClassification,//A parameter value that represents the load classification units, as used in electrical disciplines.
        Image,//The value of this parameter is the id of an image.
        MultilineText,//The value of this parameter will be represented as multiline text.
        HVACDensity,//The data value will be represented as a HVACDensity.
        HVACEnergy,//The data value will be represented as a HVACEnergy.
        HVACFriction,//The data value will be represented as a HVACFriction.
        HVACPower,//The data value will be represented as a HVACPower.
        HVACPowerDensity,//The data value will be represented as a HVACPowerDensity.
        HVACPressure,//The data value will be represented as a HVACPressure.
        HVACTemperature,//The data value will be represented as a HVACTemperature.
        HVACVelocity,//The data value will be represented as a HVACVelocity.
        HVACAirflow,//The data value will be represented as a HVACAirflow.
        HVACDuctSize,//The data value will be represented as a HVACDuctSize.
        HVACCrossSection,//The data value will be represented as a HVACCrossSection.
        HVACHeatGain,//The data value will be represented as a HVACHeatGain.
        ElectricalCurrent,//The data value will be represented as an ElectricalCurrent.
        ElectricalPotential,//The data value will be represented as an ElectricalPotential.
        ElectricalFrequency,//The data value will be represented as an ElectricalFrequency.
        ElectricalIlluminance,//The data value will be represented as an ElectricalIlluminance.
        ElectricalLuminousFlux,//The data value will be represented as an ElectricalLuminousFlux.
        ElectricalPower,//The data value will be represented as an ElectricalPower.
        HVACRoughness,//The data value will be represented as a HVACRoughness.
        ElectricalApparentPower,//The data value will be represented as an ElectricalApparentPower.
        ElectricalPowerDensity,//The data value will be represented as an ElectricalPowerDensity.
        PipingDensity,//The data value will be represented as a PipingDensity.
        PipingFlow,//The data value will be represented as a PipingFlow.
        PipingFriction,//The data value will be represented as a PipingFriction.
        PipingPressure,//The data value will be represented as a PipingPressure.
        PipingTemperature,//The data value will be represented as a PipingTemperature.
        PipingVelocity,//The data value will be represented as a PipingVelocity.
        PipingViscosity,//The data value will be represented as a PipingViscosity.
        PipeSize,//The data value will be represented as a PipeSize.
        PipingRoughness,//The data value will be represented as a PipingRoughness.
        Stress,//The data value will be represented as a Stress.
        UnitWeight,//The data value will be represented as a UnitWeight.
        ThermalExpansion,//The data value will be represented as a ThermalExpansion.
        LinearMoment,//The data value will be represented as a LinearMoment.
        ForcePerLength,//The data value will be represented as a ForcePerLength.
        ForceLengthPerAngle,//The data value will be represented as a ForceLengthPerAngle.
        LinearForcePerLength,//The data value will be represented as a LinearForcePerLength.
        LinearForceLengthPerAngle,//The data value will be represented as a LinearForceLengthPerAngle.
        AreaForcePerLength,//The data value will be represented as an AreaForcePerLength.
        PipingVolume,//The data value will be represented as a PipingVolume.
        HVACViscosity,//The data value will be represented as a HVACViscosity.
        HVACCoefficientOfHeatTransfer,//The data value will be represented as a HVACCoefficientOfHeatTransfer.
        HVACAirflowDensity,//The data value will be represented as a HVACAirflowDensity.
        Slope,//The data value will be represented as a Slope.
        HVACCoolingLoad,//The data value will be represented as a HVACCoolingLoad.
        HVACCoolingLoadDividedByArea,//The data value will be represented as a HVACCoolingLoadDividedByArea.
        HVACCoolingLoadDividedByVolume,//The data value will be represented as a HVACCoolingLoadDividedByVolume.
        HVACHeatingLoad,//The data value will be represented as a HVACHeatingLoad.
        HVACHeatingLoadDividedByArea,//The data value will be represented as a HVACHeatingLoadDividedByArea.
        HVACHeatingLoadDividedByVolume,//The data value will be represented as a HVACHeatingLoadDividedByVolume.
        HVACAirflowDividedByVolume,//The data value will be represented as a HVACAirflowDividedByVolume.
        HVACAirflowDividedByCoolingLoad,//The data value will be represented as a HVACAirflowDividedByCoolingLoad.
        HVACAreaDividedByCoolingLoad,//The data value will be represented as a HVACAreaDividedByCoolingLoad.
        WireSize,//The data value will be represented as a WireSize.
        HVACSlope,//The data value will be represented as a HVACSlope.
        PipingSlope,//The data value will be represented as a PipingSlope.
        Currency,//The data value will be represented as a Currency.
        ElectricalEfficacy,//The data value will be represented as an ElectricalEfficacy.
        ElectricalWattage,//The data value will be represented as an ElectricalWattage.
        ColorTemperature,//The data value will be represented as a ColorTemperature.
        ElectricalLuminousIntensity,//The data value will be represented as an ElectricalLuminousIntensity.
        ElectricalLuminance,//The data value will be represented as an ElectricalLuminance.
        HVACAreaDividedByHeatingLoad,//The data value will be represented as a HVACAreaDividedByHeatingLoad.
        HVACFactor,//The data value will be represented as a HVACFactor.
        ElectricalTemperature,//The data value will be represented as a ElectricalTemperature.
        ElectricalCableTraySize,//The data value will be represented as a ElectricalCableTraySize.
        ElectricalConduitSize,//The data value will be represented as a ElectricalConduitSize.
        ReinforcementVolume,//The data value will be represented as a ReinforcementVolume.
        ReinforcementLength,//The data value will be represented as a ReinforcementLength.
        ElectricalDemandFactor,//The data value will be represented as a ElectricalDemandFactor.
        HVACDuctInsulationThickness,//The data value will be represented as a HVACDuctInsulationThickness.
        HVACDuctLiningThickness,//The data value will be represented as a HVACDuctLiningThickness.
        PipeInsulationThickness,//The data value will be represented as a PipeInsulationThickness.
        HVACThermalResistance,//The data value will be represented as a HVACThermalResistance.
        HVACThermalMass,//The data value will be represented as a HVACThermalMass.
        Acceleration,//The data value will be represented as an Acceleration.
        BarDiameter,//The data value will be represented as a BarDiameter.
        CrackWidth,//The data value will be represented as a CrackWidth.
        DisplacementDeflection,//The data value will be represented as a DisplacementDeflection.
        Energy,//The data value will be represented as an Energy.
        StructuralFrequency,//The data value will be represented as a StructuralFrequency.
        Mass,//The data value will be represented as a Mass.
        MassPerUnitLength,//The data value will be represented as a MassPerUnitLength.
        MomentOfInertia,//The data value will be represented as a MomentOfInertia.
        SurfaceArea,//The data value will be represented as a SurfaceArea.
        Period,//The data value will be represented as a Period.
        Pulsation,//The data value will be represented as a Pulsation.
        ReinforcementArea,//The data value will be represented as a ReinforcementArea.
        ReinforcementAreaPerUnitLength,//The data value will be represented as a ReinforcementAreaPerUnitLength.
        ReinforcementCover,//The data value will be represented as a ReinforcementCover.
        ReinforcementSpacing,//The data value will be represented as a ReinforcementSpacing.
        Rotation,//The data value will be represented as a Rotation.
        SectionArea,//The data value will be represented as a SectionArea.
        SectionDimension,//The data value will be represented as a SectionDimension.
        SectionModulus,//The data value will be represented as a SectionModulus.
        SectionProperty,//The data value will be represented as a SectionProperty.
        StructuralVelocity,//The data value will be represented as a StructuralVelocity.
        WarpingConstant,//The data value will be represented as a WarpingConstant.
        Weight,//The data value will be represented as a Weight.
        WeightPerUnitLength,//The data value will be represented as a WeightPerUnitLength.
        HVACThermalConductivity,//The data value will be represented as a HVACThermalConductivity.
        HVACSpecificHeat,//The data value will be represented as a HVACSpecificHeat.
        HVACSpecificHeatOfVaporization,//The data value will be represented as a HVACSpecificHeatOfVaporization.
        HVACPermeability,//The data value will be represented as a HVACPermeability.
        ElectricalResistivity,//The data value will be represented as a ElectricalResistivity.
        MassDensity,//The data value will be represented as a MassDensity.
        MassPerUnitArea,//The data value will be represented as a MassPerUnitArea.
        PipeDimension,//The value of this parameter will be a Pipe Dimension
        PipeMass,//The value of this parameter will be the Pipe Mass
        PipeMassPerUnitLength,//The value of this parameter will be the Pipe Mass per Unit Length
        HVACTemperatureDifference,//The data value will be represented as a HVACTemperatureDifference.
        PipingTemperatureDifference,//The data value will be represented as a PipingTemperatureDifference.
        ElectricalTemperatureDifference,//The data value will be represented as an ElectricalTemperatureDifference.
        TimeInterval,//The data value will be represented as a TimeInterval
        Speed,//The data value will be represented as a Speed
    }
}
