﻿namespace BlazeIL.il2cpp
{
    public enum IL2BindingFlags
    {
        VISIBILITY_MASK = 0x00000007,
        ACCESS_MASK = 0x0007,

        // Types
        TYPE_NOT_PUBLIC = 0x00000000,
        TYPE_PUBLIC = 0x00000001,
        TYPE_NESTED_PUBLIC = 0x00000002,
        TYPE_NESTED_PRIVATE = 0x00000003,
        TYPE_NESTED_FAMILY = 0x00000004,
        TYPE_NESTED_ASSEMBLY = 0x00000005,
        TYPE_NESTED_FAM_AND_ASSEM = 0x00000006,
        TYPE_NESTED_FAM_OR_ASSEM = 0x00000007,
        TYPE_LAYOUT_MASK = 0x00000018,
        TYPE_AUTO_LAYOUT = 0x00000000,
        TYPE_SEQUENTIAL_LAYOUT = 0x00000008,
        TYPE_EXPLICIT_LAYOUT = 0x00000010,
        TYPE_CLASS_SEMANTIC_MASK = 0x00000020,
        TYPE_CLASS = 0x00000000,
        TYPE_INTERFACE = 0x00000020,
        TYPE_ABSTRACT = 0x00000080,
        TYPE_SEALED = 0x00000100,
        TYPE_SPECIAL_NAME = 0x00000400,
        TYPE_IMPORT = 0x00001000,
        TYPE_SERIALIZABLE = 0x00002000,
        TYPE_WINDOWS_RUNTIME = 0x00004000,
        TYPE_STRING_FORMAT_MASK = 0x00030000,
        TYPE_ANSI_CLASS = 0x00000000,
        TYPE_UNICODE_CLASS = 0x00010000,
        TYPE_AUTO_CLASS = 0x00020000,
        TYPE_BEFORE_FIELD_INIT = 0x00100000,
        TYPE_FORWARDER = 0x00200000,
        TYPE_RESERVED_MASK = 0x00040800,
        TYPE_RT_SPECIAL_NAME = 0x00000800,
        TYPE_HAS_SECURITY = 0x00040000,

        // Methods
        METHOD_COMPILER_CONTROLLED = 0x0000,
        METHOD_PRIVATE = 0x0001,
        METHOD_FAM_AND_ASSEM = 0x0002,
        METHOD_ASSEM = 0x0003,
        METHOD_FAMILY = 0x0004,
        METHOD_FAM_OR_ASSEM = 0x0005,
        METHOD_PUBLIC = 0x0006,
        METHOD_STATIC = 0x0010,
        METHOD_FINAL = 0x0020,
        METHOD_VIRTUAL = 0x0040,
        METHOD_HIDE_BY_SIG = 0x0080,
        METHOD_VTABLE_LAYOUT_MASK = 0x0100,
        METHOD_REUSE_SLOT = 0x0000,
        METHOD_NEW_SLOT = 0x0100,
        METHOD_STRICT = 0x0200,
        METHOD_ABSTRACT = 0x0400,
        METHOD_SPECIAL_NAME = 0x0800,
        METHOD_PINVOKE_IMPL = 0x2000,
        METHOD_UNMANAGED_EXPORT = 0x0008,
        METHOD_RESERVED_MASK = 0xd000,
        METHOD_RT_SPECIAL_NAME = 0x1000,
        METHOD_HAS_SECURITY = 0x4000,
        METHOD_REQUIRE_SEC_OBJECT = 0x8000,

        // Fields
        FIELD_COMPILER_CONTROLLED = 0x0000,
        FIELD_PRIVATE = 0x0001,
        FIELD_FAM_AND_ASSEM = 0x0002,
        FIELD_ASSEMBLY = 0x0003,
        FIELD_FAMILY = 0x0004,
        FIELD_FAM_OR_ASSEM = 0x0005,
        FIELD_PUBLIC = 0x0006,
        FIELD_STATIC = 0x0010,
        FIELD_INIT_ONLY = 0x0020,
        FIELD_LITERAL = 0x0040,
        FIELD_NOT_SERIALIZED = 0x0080,
        FIELD_SPECIAL_NAME = 0x0200,
        FIELD_PINVOKE_IMPL = 0x2000,
        FIELD_RESERVED_MASK = 0x9500,
        FIELD_RT_SPECIAL_NAME = 0x0400,
        FIELD_HAS_FIELD_MARSHAL = 0x1000,
        FIELD_HAS_DEFAULT = 0x8000,
        FIELD_HAS_FIELD_RVA = 0x0100,
    }
}
