using System;
using System.Runtime.InteropServices;

namespace Pocketsphinx
{
    [StructLayout(LayoutKind.Sequential)]
    public struct trans_list_s
    {
        hash_table_t* null_trans;   /* Null transitions keyed by state. */
        hash_table_t* trans;        /* Lists of non-null transitions keyed by state. */

    }


    [StructLayout(LayoutKind.Sequential)]
    public struct hash_table_s
    {
        hash_entry_t* table;    /**Primary hash table, excluding entries that collide */
        public int size;
        public int inuse;
        public int nocase;


    }



    [StructLayout(LayoutKind.Sequential)]
    public struct hash_table_s
    {
        char key;
        size_t len;
        void val;
        hash_entry_s next;
    }
}