﻿using ACadSharp.IO.Templates;

namespace ACadSharp.Tables.Collections
{
	public class UCSTable : Table<UCS>
	{
		/// <inheritdoc/>
		public override ObjectType ObjectType => ObjectType.UCS_CONTROL_OBJ;

		internal UCSTable() : base() { }

		internal UCSTable(CadDocument document) : base(document) { }
	}
}