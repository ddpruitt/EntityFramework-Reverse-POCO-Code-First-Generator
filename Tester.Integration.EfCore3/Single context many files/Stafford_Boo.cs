// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.co.uk/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Registered to: Simon Hughes
// Company      : Reverse POCO
// Licence Type : Commercial
// Licences     : 1
// Valid until  : 03 NOV 2020
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Connection String Name: "EfCoreDatabase"
//     Connection String:      "Data Source=(local);Initial Catalog=EfrpgTest;Integrated Security=True"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise
// Database Version       : 14.0.2027.2

// <auto-generated>
// ReSharper disable CheckNamespace
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedVariable
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantCast
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// ReSharper disable UsePatternMatching
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3.Single_context_many_files
{
    // Boo
    public class Stafford_Boo
    {
        public int Id { get; set; } // id (Primary key)
        public string Name { get; set; } // name (length: 10)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Stafford_Boo pointed by [Foo].[id] (FK_Foo_Boo)
        /// </summary>
        public virtual Stafford_Foo Stafford_Foo { get; set; } // Foo.FK_Foo_Boo
    }

}
// </auto-generated>

