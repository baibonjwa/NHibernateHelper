using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhibernateHelper
{
    public abstract class Property
    {

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String field;

        public String Field
        {
            get { return field; }
            set { field = value; }
        }

        private String entity;

        public String Entity
        {
            get { return entity; }
            set { entity = value; }
        }
    }

    public class PropertyGeneral : Property
    {
        private String proType;

        public String ProType
        {
            get { return proType; }
            set { proType = value; }
        }
    }
    public class PropertyKey : Property
    {
        private String keyType;

        public String KeyType
        {
            get { return keyType; }
            set { keyType = value; }
        }
    }
    public class PropertyMoreToOne : Property
    {
        private String proType;

        public String ProType
        {
            get { return proType; }
            set { proType = value; }
        }
    }
    public class PropertyOneToMore : Property
    {
        private String tableName;

        public String TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        private String keyColoumName;

        public String KeyColoumName
        {
            get { return keyColoumName; }
            set { keyColoumName = value; }
        }

        private String entityName;

        public String EntityName
        {
            get { return entityName; }
            set { entityName = value; }
        }

        private bool cascade;

        public bool Cascade
        {
            get { return cascade; }
            set { cascade = value; }
        }

        private bool inverse;

        public bool Inverse
        {
            get { return inverse; }
            set { inverse = value; }
        }
    }

}
