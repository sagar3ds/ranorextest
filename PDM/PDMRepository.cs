﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace PDM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the PDMRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("501db1bd-223a-4529-884b-698a523e8a82")]
    public partial class PDMRepository : RepoGenBaseFolder
    {
        static PDMRepository instance = new PDMRepository();

        /// <summary>
        /// Gets the singleton class instance representing the PDMRepository element repository.
        /// </summary>
        [RepositoryFolder("501db1bd-223a-4529-884b-698a523e8a82")]
        public static PDMRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public PDMRepository() 
            : base("PDMRepository", "/", null, 0, false, "501db1bd-223a-4529-884b-698a523e8a82", ".\\RepositoryImages\\PDMRepository501db1bd.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("501db1bd-223a-4529-884b-698a523e8a82")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class PDMRepositoryFolders
    {
    }
#pragma warning restore 0436
}
