using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Session_11
{
    public partial class Form1 : Form
    {
        public Transaction transaction;
        public Form1()
        {
            InitializeComponent();
            var pets = this.list;
            dataGridView2.DataSource = pets;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pet pet = new Pet();
            Transaction newTras = new Transaction();
            Customer newCustomer = new Customer()
            {
                Name = "Nikos",
                Surname = "Karamitos",
                Phone = "6978319622",
                TIN = "12390812903"
            };
           
            Buy(newCustomer,pet);

         
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnCancerl_Click(object sender, EventArgs e)
        {

        }



            public Transaction Buy(Customer customer, Pet pet)
            {
             
            Transaction newTras=new Transaction();

                switch (pet.AnimalType)
                {
                    case Pet.AnimalTypeEnum.Bird:
                        newTras = SelectBird(pet);
                        break;

                case Pet.AnimalTypeEnum.Cat:
                    break;

                case Pet.AnimalTypeEnum.Dog:
                    break;


                default:

                    break;

                }

                return newTras;


            }

           public Transaction SelectBird(Pet pet)
            {
            Transaction tras=new Transaction();
            if (pet.Status.ToString() == "Unhealthy")
            {
                return null;
            }
            else
            {
                tras.PetFoodPrice = 5;
                tras.PetFoodQty = 3;
                tras.PetPrice = pet.Price;
                tras.PetID = pet.PetID;
                tras.TransactionDate = DateTime.Now;
                tras.TotalPrice = pet.Price + (tras.PetFoodPrice * (tras.PetFoodQty-1));
                
            }
            return tras;
        }
        static Pet petcat = new Pet()
        {
            AnimalType = Pet.AnimalTypeEnum.Cat,
            Status = Pet.PetStatusEnum.OK,
            Breed = "black",
            Price = 10,
            Cost = 10

        };
        static Pet petDog = new Pet()
        {
            AnimalType = Pet.AnimalTypeEnum.Dog,
            Status = Pet.PetStatusEnum.OK,
            Breed = "black",
            Price = 10,
            Cost = 10

        };
        static
        Pet petBird = new Pet()
        {
            AnimalType = Pet.AnimalTypeEnum.Bird,
            Status = Pet.PetStatusEnum.OK,
            Breed = "black",
            Price = 10,
            Cost = 10

        };

        List<Pet> list = new List<Pet>() { petcat, petDog, petBird };

        PetShop petShop = new PetShop()
        {

            pets = new List<Pet>() {
                petcat, petDog,petBird
            }

        };
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pet pricing
        }
    }
    }
