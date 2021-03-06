﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
using System;
using System.Collections.ObjectModel;

#pragma warning disable RCS1016, RCS1019, RCS1060, RCS1078, RCS1079, RCS1100, RCS1106, RCS1108

namespace Roslynator.CSharp.Analyzers.Test
{
    interface InterfaceName123
    {
    }

    enum EnumName123
    {
    }

    struct StructName123
    {
    }

    delegate void DelegateName123();

    static class AddDefaultAccessModifier
    {
        interface InterfaceName
        {
            void MethodName();
            string PropertyName { get; set; }
            object this[int index] { get; set; }
            event EventHandler EventName;
        }

        enum EnumName
        {
        }

        struct StructName
        {
        }

        delegate void DelegateName();

        class ClassName : InterfaceName
        {
            static ClassName()
            {
            }

            ClassName()
            {
            }

            ~ClassName()
            {
            }

            static explicit operator ClassName(string value)
            {
                return new ClassName();
            }

            static explicit operator string(ClassName value)
            {
                return string.Empty;
            }

            static ClassName operator !(ClassName value)
            {
                return new ClassName();
            }

            delegate void DelegateName();

            event EventHandler EventName2;

            event EventHandler EventName3
            {
                add { }
                remove { }
            }

            string _fieldName;

            object this[int index]
            {
                get { return Items[index]; }
                set { Items[index] = value; }
            }

            Collection<object> Items { get; } = new Collection<object>();

            /// <summary>
            /// ...
            /// </summary>
            /// <returns></returns>
            string /**/ MethodName()
            {
                return _fieldName;
            }

            /// <summary>
            /// ...
            /// </summary>
            /// <returns></returns>
            static /**/ string StaticMethodName()
            {
                return string.Empty;
            }

            event EventHandler InterfaceName.EventName
            {
                add { throw new NotImplementedException(); }
                remove { throw new NotImplementedException(); }
            }

            void InterfaceName.MethodName()
            {
                throw new NotImplementedException();
            }

            string InterfaceName.PropertyName
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }

            object InterfaceName.this[int index]
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }
        }
    }

    public partial class PartialClass
    {
    }

    partial class PartialClass
    {
        partial void PartialMethod();
    }

    partial class PartialClass
    {
        partial void PartialMethod()
        {
        }

        protected class PartialClass2
        {
        }
    }

    class PartialClasss : PartialClass
    {
        new class PartialClass2
        {
        }
    }

    /*****/

    static partial class PartialClass2
    {
    }

    partial class PartialClass2
    {
        /*****/

        partial class PartialClass3
        {
        }

        protected internal partial class PartialClass3
        {
        }

        /*****/

        partial class PartialClass4
        {
        }

        internal protected partial class PartialClass4
        {
        }

        /*****/

        partial class PartialClass5
        {
        }

        protected partial class PartialClass5
        {
        }

        /*****/

        partial class PartialClass6
        {
        }

        internal partial class PartialClass6
        {
        }

        /*****/

        partial class PartialClass7
        {
        }

        partial class PartialClass7
        {
        }
    }
}
