﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Framework.CodeGeneration.CommandLine;

namespace Microsoft.Framework.CodeGenerators.Mvc
{
    //Command line parameters common to controller and view scaffolder.
    public abstract class CommanCommandLineModel
    {
        [Option(Name = "model", ShortName = "m", Description = "Model class to use")]
        public string ModelClass { get; set; }

        [Option(Name = "dataContext", ShortName = "dc", Description = "DbContext class to use")]
        public string DataContextClass { get; set; }

        [Option(Name = "referenceScriptLibraries", ShortName = "scripts", Description = "Switch to specify whether to reference script libraries in the generated views")]
        public bool ReferenceScriptLibraries { get; set; }

        [Option(Name = "layout", ShortName = "l", Description = "Custom Layout page to use")]
        public string LayoutPage { get; set; }

        [Option(Name = "useDefaultLayout", ShortName = "udl", Description = "Switch to specify that default layout should be used for the views")]
        public bool UseDefaultLayout { get; set; }

        [Option(Name = "force", ShortName = "f", Description = "Use this option to overwrite existing files")]
        public bool Force { get; set; }
    }
}