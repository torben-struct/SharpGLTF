//------------------------------------------------------------------------------------------------
//      This file has been programatically generated; DON´T EDIT!
//------------------------------------------------------------------------------------------------

#pragma warning disable SA1001
#pragma warning disable SA1027
#pragma warning disable SA1028
#pragma warning disable SA1121
#pragma warning disable SA1205
#pragma warning disable SA1309
#pragma warning disable SA1402
#pragma warning disable SA1505
#pragma warning disable SA1507
#pragma warning disable SA1508
#pragma warning disable SA1652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using Newtonsoft.Json;

namespace SharpGLTF.Schema2
{
	using Collections;

	/// <summary>
	/// glTF extension that defines the specular-glossiness material model from Physically-Based Rendering (PBR) methodology.
	/// </summary>
	partial class MaterialPBRSpecularGlossiness : ExtraProperties
	{
	
		private static readonly Vector4 _diffuseFactorDefault = Vector4.One;
		private Vector4? _diffuseFactor = _diffuseFactorDefault;
		
		private TextureInfo _diffuseTexture;
		
		private const Double _glossinessFactorDefault = 1;
		private const Double _glossinessFactorMinimum = 0;
		private const Double _glossinessFactorMaximum = 1;
		private Double? _glossinessFactor = _glossinessFactorDefault;
		
		private static readonly Vector3 _specularFactorDefault = Vector3.One;
		private Vector3? _specularFactor = _specularFactorDefault;
		
		private TextureInfo _specularGlossinessTexture;
		
	
		/// <inheritdoc />
		protected override void SerializeProperties(JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "diffuseFactor", _diffuseFactor, _diffuseFactorDefault);
			SerializePropertyObject(writer, "diffuseTexture", _diffuseTexture);
			SerializeProperty(writer, "glossinessFactor", _glossinessFactor, _glossinessFactorDefault);
			SerializeProperty(writer, "specularFactor", _specularFactor, _specularFactorDefault);
			SerializePropertyObject(writer, "specularGlossinessTexture", _specularGlossinessTexture);
		}
	
		/// <inheritdoc />
		protected override void DeserializeProperty(string property, JsonReader reader)
		{
			switch (property)
			{
				case "diffuseFactor": _diffuseFactor = DeserializePropertyValue<Vector4?>(reader); break;
				case "diffuseTexture": _diffuseTexture = DeserializePropertyValue<TextureInfo>(reader); break;
				case "glossinessFactor": _glossinessFactor = DeserializePropertyValue<Double?>(reader); break;
				case "specularFactor": _specularFactor = DeserializePropertyValue<Vector3?>(reader); break;
				case "specularGlossinessTexture": _specularGlossinessTexture = DeserializePropertyValue<TextureInfo>(reader); break;
				default: base.DeserializeProperty(property, reader); break;
			}
		}
	
	}

}
