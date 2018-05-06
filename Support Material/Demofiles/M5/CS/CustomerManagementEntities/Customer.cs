using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerManagementEntities
{
    public class Customer
    {
        private Guid? customerID;
        private string customerName = null;
        private string customerAddress = null;
        private string customerPhone = null;
        private string customerZipCode = null;
        private string customerCity = null;
        private string customerState = null;
        private Guid? customerCountryID = null;
        private string customerEmailAddress = null;
        private int customerCreditLimit = 0;
        private DateTime? customerCreatedDate = null;
        private string customerCreatedBy = null;
        private DateTime? customerModifiedDate = null;
        private string customerModifiedBy = null;

        /// <summary>
        /// The unique customer ID
        /// </summary>
        public Guid? ID
        {
            get
            {
                return this.customerID;
            }
            private set
            {
                this.customerID = value;
            }
        }

        /// <summary>
        /// The full customer name
        /// </summary>
        public string Name
        {
            get
            {
                return this.customerName;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerName = "";
                else
                    // Only get the first 50 characters
                    if (value.Length > 50)
                        this.customerName = value.Substring(0, 50);
                    else
                        this.customerName = value;
            }
        }

        /// <summary>
        /// The customer address, including street name, house number and floor
        /// </summary>
        public string Address
        {
            get
            {
                return this.customerAddress;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerAddress = "";
                else
                    // Only get the first 50 characters
                    if (value.Length > 50)
                        this.customerAddress = value.Substring(0, 50);
                    else
                        this.customerAddress = value;
            }
        }

        /// <summary>
        /// The customer phone number
        /// </summary>
        public string Phone
        {
            get
            {
                return this.customerPhone;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerPhone = "";
                else
                    // Only get the first 30 characters
                    if (value.Length > 30)
                        this.customerPhone = value.Substring(0, 30);
                    else
                        this.customerPhone = value;
            }
        }

        /// <summary>
        /// The customer zip code or postal code
        /// </summary>
        public string ZipCode
        {
            get
            {
                return this.customerZipCode;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerZipCode = "";
                else
                    // Only get the first 10 characters
                    if (value.Length > 10)
                        this.customerZipCode = value.Substring(0, 10);
                    else
                        this.customerZipCode = value;
            }
        }

        /// <summary>
        /// The name of the city in which the customer lives
        /// </summary>
        public string City
        {
            get
            {
                return this.customerCity;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerCity = "";
                else
                    // Only get the first 30 characters
                    if (value.Length > 30)
                        this.customerCity = value.Substring(0, 30);
                    else
                        this.customerCity = value;
            }
        }

        /// <summary>
        /// The name of the state or region in which the customer lives
        /// </summary>
        public string State
        {
            get
            {
                return this.customerState;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerState = "";
                else
                    // Only get the first 30 characters
                    if (value.Length > 30)
                        this.customerState = value.Substring(0, 30);
                    else
                        this.customerState = value;
            }
        }

        /// <summary>
        /// The ID of the country in which the customer lives
        /// </summary>
        public Guid? CountryID
        {
            get
            {
                return this.customerCountryID;
            }
            set
            {
                this.customerCountryID = value;
            }
        }

        /// <summary>
        /// The customer e-mail address
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return this.customerEmailAddress;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerEmailAddress = "";
                else
                    // Only get the first 40 characters
                    if (value.Length > 40)
                        this.customerEmailAddress = value.Substring(0, 40);
                    else
                        this.customerEmailAddress = value;
            }
        }

        /// <summary>
        /// The current credit limit of the customer
        /// </summary>
        public int CreditLimit
        {
            get
            {
                return this.customerCreditLimit;
            }
            set
            {
                // Negative value?
                if (value < 0)
                    this.customerCreditLimit = 0;
                else
                    this.customerCreditLimit = value;
            }
        }

        /// <summary>
        /// The date the customer was created in the system
        /// </summary>
        public DateTime? CreatedDate
        {
            get
            {
                return this.customerCreatedDate;
            }
            private set
            {
                // Date in the past?
                if (value < DateTime.Now)
                    this.customerCreatedDate = DateTime.Now;
                else
                    this.customerCreatedDate = value;
            }
        }

        /// <summary>
        /// The name of the user creating the customer
        /// </summary>
        public string CreatedBy
        {
            get
            {
                return this.customerCreatedBy;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerCreatedBy = "";
                else
                    // Only get the first 15 characters
                    if (value.Length > 15)
                        this.customerCreatedBy = value.Substring(0, 15);
                    else
                        this.customerCreatedBy = value;
            }
        }

        /// <summary>
        /// The date the customer was last modified in the system
        /// </summary>
        public DateTime? ModifiedDate
        {
            get
            {
                return this.customerModifiedDate;
            }
            set
            {
                // Date in the past?
                if (value < DateTime.Now)
                    this.customerModifiedDate = DateTime.Now;
                else
                    this.customerModifiedDate = value;
            }
        }

        /// <summary>
        /// The name of the user who last modified the customer
        /// </summary>
        public string ModifiedBy
        {
            get
            {
                return this.customerModifiedBy;
            }
            set
            {
                // Null value?
                if (value == null)
                    this.customerModifiedBy = "";
                else
                    // Only get the first 15 characters
                    if (value.Length > 15)
                        this.customerModifiedBy = value.Substring(0, 15);
                    else
                        this.customerModifiedBy = value;
            }
        }

        /// <summary>
        /// Default parameterless constructor
        /// </summary>
        public Customer()
        {
            // Initialize member backing fields with default values
            this.ID = Guid.NewGuid();
            this.CreatedDate = DateTime.Now;
        }

        public Customer(Guid? id)
        {
            // Initialize member backing fields with 
            // passed and default values
            this.ID = id;
            this.CreatedDate = DateTime.Now;
        }

        /// <summary>
        /// Initializes with a value for all backing fields 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="zipCode"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="countryID"></param>
        /// <param name="emailAddress"></param>
        /// <param name="creditLimit"></param>
        /// <param name="createdDate"></param>
        /// <param name="createdBy"></param>
        /// <param name="modifiedDate"></param>
        /// <param name="modifiedBy"></param>
        public Customer(Guid? id, string name, string address, string phone,
            string zipCode, string city, string state, Guid? countryID,
            string emailAddress, int creditLimit, DateTime? createdDate,
            string createdBy, DateTime? modifiedDate, string modifiedBy)
        {
            // Initialize member backing fields with passed values
            this.ID = id;
            this.CreatedDate = DateTime.Now;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.ZipCode = zipCode;
            this.City = city;
            this.State = state;
            this.CountryID = countryID;
            this.EmailAddress = emailAddress;
            this.CreditLimit = creditLimit;
            this.CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            this.ModifiedDate = modifiedDate;
            this.ModifiedBy = modifiedBy;
        }
    }
}