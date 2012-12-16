﻿#region License Header
/***************************************************************************
 *   Copyright (c) 2011 OpenUO Software Team.
 *   All Right Reserved.
 *
 *   $Id: $:
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 ***************************************************************************/
 #endregion

using OpenUO.Ultima.Adapters;
using OpenUO.Core.Patterns;

namespace OpenUO.Ultima
{
    public class GumpFactory : AdapterFactoryBase
    {
        public GumpFactory(InstallLocation install, Container container)
            : base(install, container) { }

        public T GetGump<T>(int index)
        {
            return GetAdapter<IGumpStorageAdapter<T>>().GetGump(index);
        }

        public int GetLength<T>()
        {
            return GetAdapter<IGumpStorageAdapter<T>>().Length;
        }
    }
}
