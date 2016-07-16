// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Map/Pokemon/MapPokemon.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOLib.Pokemon.Proto.Map.Pokemon {

  /// <summary>Holder for reflection information generated from Map/Pokemon/MapPokemon.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class MapPokemonReflection {

    #region Descriptor
    /// <summary>File descriptor for Map/Pokemon/MapPokemon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapPokemonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxNYXAvUG9rZW1vbi9NYXBQb2tlbW9uLnByb3RvEiFQT0dPTGliLlBva2Vt",
            "b24uUHJvdG8uTWFwLlBva2Vtb24aE0VudW1zL1Bva2Vtb24ucHJvdG8iuwEK",
            "Ck1hcFBva2Vtb24SFQoNc3Bhd25wb2ludF9pZBgBIAEoCRIUCgxlbmNvdW50",
            "ZXJfaWQYAiABKAYSOgoMcG9rZW1vbl90eXBlGAMgASgOMiQuUE9HT0xpYi5Q",
            "b2tlbW9uLlByb3RvLkVudW1zLlBva2Vtb24SHwoXZXhwaXJhdGlvbl90aW1l",
            "c3RhbXBfbXMYBCABKAMSEAoIbGF0aXR1ZGUYBSABKAESEQoJbG9uZ2l0dWRl",
            "GAYgASgBUABiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOLib.Pokemon.Proto.Enums.PokemonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOLib.Pokemon.Proto.Map.Pokemon.MapPokemon), global::POGOLib.Pokemon.Proto.Map.Pokemon.MapPokemon.Parser, new[]{ "SpawnpointId", "EncounterId", "PokemonType", "ExpirationTimestampMs", "Latitude", "Longitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class MapPokemon : pb::IMessage<MapPokemon> {
    private static readonly pb::MessageParser<MapPokemon> _parser = new pb::MessageParser<MapPokemon>(() => new MapPokemon());
    public static pb::MessageParser<MapPokemon> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOLib.Pokemon.Proto.Map.Pokemon.MapPokemonReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public MapPokemon() {
      OnConstruction();
    }

    partial void OnConstruction();

    public MapPokemon(MapPokemon other) : this() {
      spawnpointId_ = other.spawnpointId_;
      encounterId_ = other.encounterId_;
      pokemonType_ = other.pokemonType_;
      expirationTimestampMs_ = other.expirationTimestampMs_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
    }

    public MapPokemon Clone() {
      return new MapPokemon(this);
    }

    /// <summary>Field number for the "spawnpoint_id" field.</summary>
    public const int SpawnpointIdFieldNumber = 1;
    private string spawnpointId_ = "";
    public string SpawnpointId {
      get { return spawnpointId_; }
      set {
        spawnpointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 2;
    private ulong encounterId_;
    public ulong EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_type" field.</summary>
    public const int PokemonTypeFieldNumber = 3;
    private global::POGOLib.Pokemon.Proto.Enums.Pokemon pokemonType_ = 0;
    public global::POGOLib.Pokemon.Proto.Enums.Pokemon PokemonType {
      get { return pokemonType_; }
      set {
        pokemonType_ = value;
      }
    }

    /// <summary>Field number for the "expiration_timestamp_ms" field.</summary>
    public const int ExpirationTimestampMsFieldNumber = 4;
    private long expirationTimestampMs_;
    /// <summary>
    ///  After this timestamp, the pokemon will be gone.
    /// </summary>
    public long ExpirationTimestampMs {
      get { return expirationTimestampMs_; }
      set {
        expirationTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 5;
    private double latitude_;
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 6;
    private double longitude_;
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as MapPokemon);
    }

    public bool Equals(MapPokemon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpawnpointId != other.SpawnpointId) return false;
      if (EncounterId != other.EncounterId) return false;
      if (PokemonType != other.PokemonType) return false;
      if (ExpirationTimestampMs != other.ExpirationTimestampMs) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SpawnpointId.Length != 0) hash ^= SpawnpointId.GetHashCode();
      if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
      if (PokemonType != 0) hash ^= PokemonType.GetHashCode();
      if (ExpirationTimestampMs != 0L) hash ^= ExpirationTimestampMs.GetHashCode();
      if (Latitude != 0D) hash ^= Latitude.GetHashCode();
      if (Longitude != 0D) hash ^= Longitude.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SpawnpointId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SpawnpointId);
      }
      if (EncounterId != 0UL) {
        output.WriteRawTag(17);
        output.WriteFixed64(EncounterId);
      }
      if (PokemonType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) PokemonType);
      }
      if (ExpirationTimestampMs != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ExpirationTimestampMs);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Longitude);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SpawnpointId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnpointId);
      }
      if (EncounterId != 0UL) {
        size += 1 + 8;
      }
      if (PokemonType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonType);
      }
      if (ExpirationTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTimestampMs);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(MapPokemon other) {
      if (other == null) {
        return;
      }
      if (other.SpawnpointId.Length != 0) {
        SpawnpointId = other.SpawnpointId;
      }
      if (other.EncounterId != 0UL) {
        EncounterId = other.EncounterId;
      }
      if (other.PokemonType != 0) {
        PokemonType = other.PokemonType;
      }
      if (other.ExpirationTimestampMs != 0L) {
        ExpirationTimestampMs = other.ExpirationTimestampMs;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SpawnpointId = input.ReadString();
            break;
          }
          case 17: {
            EncounterId = input.ReadFixed64();
            break;
          }
          case 24: {
            pokemonType_ = (global::POGOLib.Pokemon.Proto.Enums.Pokemon) input.ReadEnum();
            break;
          }
          case 32: {
            ExpirationTimestampMs = input.ReadInt64();
            break;
          }
          case 41: {
            Latitude = input.ReadDouble();
            break;
          }
          case 49: {
            Longitude = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code