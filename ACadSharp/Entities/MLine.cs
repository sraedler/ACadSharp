﻿using ACadSharp.Attributes;
using ACadSharp.Objects;
using CSMath;
using System;
using System.Collections.Generic;

namespace ACadSharp.Entities
{
	public partial class MLine : Entity
	{
		public override ObjectType ObjectType => ObjectType.MLINE;

		public override string ObjectName => DxfFileToken.EntityMLine;

		//100	Subclass marker(AcDbMline)

		/// <summary>
		/// String of up to 32 characters.The name of the style used for this mline.An entry for this style must exist in the MLINESTYLE dictionary.
		/// </summary>
		/// <remarks>
		/// Do not modify this field without also updating the associated entry in the MLINESTYLE dictionary
		/// </remarks>
		[DxfCodeValue(2)]
		public MLStyle Style { get; set; }
		//340	Pointer-handle/ID of MLINESTYLE object

		/// <summary>
		/// Scale factor
		/// </summary>
		[DxfCodeValue(40)]
		public double ScaleFactor { get; set; }

		/// <summary>
		/// Justification
		/// </summary>
		[DxfCodeValue(70)]
		public MLineJustification Justification { get; set; }

		/// <summary>
		/// Flags
		/// </summary>
		[DxfCodeValue(71)]
		public MLineFlags Flags { get; set; }

		/// <summary>
		/// Start point(in WCS)
		/// </summary>
		[DxfCodeValue(10, 20, 30)]
		public XYZ StartPoint { get; set; }

		/// <summary>
		/// Extrusion direction
		/// </summary>
		[DxfCodeValue(210, 220, 230)]
		public XYZ Extrusion { get; set; } = XYZ.AxisZ;

		//72	Number of vertices
		public List<Vertex> Vertices { get; set; } = new List<Vertex>();

		public MLine() : base() { }
	}
}