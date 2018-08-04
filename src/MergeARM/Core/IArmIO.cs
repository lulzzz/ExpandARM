﻿namespace MergeARM.Core
{
    public interface IArmIO
    {
        ArmTemplate LoadArmTemplate(string filePath);

        void ExpandArmTemplate(ArmTemplate armTemplate);
    }
}