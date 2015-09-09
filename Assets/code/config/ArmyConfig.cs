using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot("ArmyConfig")]
public class ArmyConfig : BaseConfig
{
    [XmlArray("ArmyInfolist")]
    public List<ArmyInfo> armyInfoList = new List<ArmyInfo>();
}

[XmlType("ArmyinfoN")]
public class ArmyInfo
{
    [XmlAttribute]
    public string Armyid;
    [XmlAttribute]
    public string Model;
    [XmlAttribute]
    public string Icon;
    [XmlAttribute]
    public string name;
    [XmlAttribute]
    public string zi;
    [XmlAttribute]
    public string des;
    [XmlAttribute]
    public string Quality;
    [XmlAttribute]
    public string SoldierId;
    [XmlAttribute]
    public float Speed;
    [XmlAttribute]
    public float AttackCDTimer;
    [XmlAttribute]
    public float hitDelay;
    [XmlAttribute]
    public float AttackRange;
    [XmlAttribute]
    public float LookRange;
    [XmlAttribute]
    public int country;
    [XmlAttribute]
    public int HP;
    [XmlAttribute]
    public int PAttackValue;
    [XmlAttribute]
    public int MAttackValue;
    [XmlAttribute]
    public int PDefenseValue;
    [XmlAttribute]
    public int MDefenseValue;
    [XmlAttribute]
    public int ForceValue;
    [XmlAttribute]
    public int CommanderValue;
    [XmlAttribute]
    public int IntelligenceValue;
    [XmlAttribute]
    public int HitRate;
    [XmlAttribute]
    public int DodgeRate;
    [XmlAttribute]
    public int BlockRate;
    [XmlAttribute]
    public int CritRate;
    [XmlAttribute]
    public int CritValue;
    [XmlAttribute]
    public int RecoveryRate;
    [XmlAttribute]
    public int PBreak;
    [XmlAttribute]
    public int MBreak;
    [XmlAttribute]
    public int EnRecovery;
    [XmlAttribute]
    public int ArmyType;
    [XmlAttribute]
    public int Job;
    [XmlAttribute]
    public string StartSkill;
    [XmlAttribute]
    public string Skill;
}
