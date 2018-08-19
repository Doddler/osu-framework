﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

namespace osu.Framework.Graphics.Shaders
{
    internal interface IUniformMapping
    {
        string Name { get; set; }

        void LinkShaderUniform(IUniform uniform);
        void UnlinkShaderUniform(IUniform uniform);
    }
}
