﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using dnSpy.Contracts.Hex.Files.ToolTips;

namespace dnSpy.Contracts.Hex.Files.DnSpy {
	/// <summary>
	/// Creates objects that can be shown in tooltips
	/// </summary>
	public abstract class ToolTipObjectFactory {
		/// <summary>
		/// Constructor
		/// </summary>
		protected ToolTipObjectFactory() { }

		/// <summary>
		/// Creates an object that can be shown in a tooltip
		/// </summary>
		/// <param name="content">Content</param>
		/// <returns></returns>
		public abstract object Create(HexToolTipContent content);
	}
}
