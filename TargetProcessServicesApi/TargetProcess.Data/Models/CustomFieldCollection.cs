using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TargetProcess.Data.Models
{
    [Serializable]
    public class CustomFieldCollection : ICollection<Field>
    {
        private readonly Dictionary<string, Field> _fields
            = new Dictionary<string, Field>();

        public Field this[string fieldName]
        {
            get { return _fields[fieldName]; }
            set { _fields[fieldName] = value; }
        }

        public void Add(Field field)
        {
            _fields.Add(field.Name, field);
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public IEnumerator<Field> GetEnumerator()
        {
            return _fields.Values.GetEnumerator();
        }

        /// <inheritdoc />
        public void Clear()
        {
            _fields.Clear();
        }

        /// <inheritdoc />
        public bool Contains(Field item)
        {
            return _fields.Keys.Contains(item.Name);
        }

        /// <inheritdoc />
        public void CopyTo(Field[] array, int arrayIndex)
        {
            _fields.Values.CopyTo(array, arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(Field item)
        {
            return _fields.Remove(item.Name);
        }

        /// <inheritdoc />
        public int Count
        {
            get { return _fields.Count; }
        }

        /// <inheritdoc />
        public bool IsReadOnly
        {
            get { return false; }
        }
    }
}