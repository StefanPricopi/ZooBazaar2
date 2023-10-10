using DataAccess;
using Logic.Entities;
using Logic.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Area_LocationManagement : Form
    {
        Area area = new Area();
        Location location = new Location();

        private readonly AreaManager areaManager;
        private readonly LocationManager locationManager;

        List<Area> areas = new List<Area>();
        List<Location> locations = new List<Location>();

        public Area_LocationManagement()
        {
            InitializeComponent();

            areaManager = new AreaManager(new AreaRepository());
            locationManager = new LocationManager(new LocationRepository());

            areas = areaManager.GetAllAreas();
            locations = locationManager.GetAllLocations();
            RefreshArea();
            RefreshLocation();
            //foreach (Area area in areas)
            //{
            //    cbArea.Items.Add(area);
            //}
        }

        public void RefreshArea()
        {
            cbArea.Items.Clear();
            lbArea.Items.Clear();
            areas = areaManager.GetAllAreas();

            foreach (Area area in areas)
            {
                lbArea.Items.Add(area);
                cbArea.Items.Add(area);
            }
        }

        public void RefreshLocation()
        {
            lbLocations.Items.Clear();
            locations = locationManager.GetAllLocations();
            foreach (Location location in locations)
            {
                lbLocations.Items.Add(location);
            }
        }


        public void ClearAllBoxes()
        {
            tbAreaName.Clear();
            tbLocationName.Clear();
            tbCapacity.Clear();
            cbArea.SelectedIndex = -1;
            rbAreaActive.Checked = false;
            rbAreaInactive.Checked = false;
            rbLocationActive.Checked = false;
            rbLocationInactive.Checked = false;
        }
        public void AddArea()
        {

            area.AreaName = tbAreaName.Text;
            if (rbAreaActive.Checked)
            {
                area.Status = "ACTIVE";
            }
            else if (rbAreaInactive.Checked)
            {
                area.Status = "INACTIVE";
            }
            areaManager.CreateArea(area.AreaToAreaDTO());
            ClearAllBoxes();
            RefreshArea();
        }

        public void AddLocation()
        {
            Area selectedArea = (Area)cbArea.SelectedItem;
            location.LocationName = tbLocationName.Text;
            location.Area = selectedArea;
            location.Capacity = Convert.ToInt32(tbCapacity.Text);
            if (rbLocationActive.Checked)
            {
                location.Status = "ACTIVE";
            }
            else if (rbLocationInactive.Checked)
            {
                location.Status = "INACTIVE";
            }
            locationManager.CreateLocation(location.LocationToLocationDTO());
            ClearAllBoxes();
            RefreshLocation();
        }

        public void UpdateArea()
        {
            area.AreaName = tbAreaName.Text;
            if (rbAreaActive.Checked)
            {
                area.Status = "ACTIVE";
            }
            else if (rbAreaInactive.Checked)
            {
                area.Status = "INACTIVE";
            }
            areaManager.UpdateArea(area.AreaToAreaDTO());
            ClearAllBoxes();
            RefreshArea();
        }

        public void UpdateLocation()
        {
            Area selectedArea = (Area)cbArea.SelectedItem;
            location.LocationName = tbLocationName.Text;
            location.Area = selectedArea;
            location.Capacity = Convert.ToInt32(tbCapacity.Text);
            if (rbLocationActive.Checked)
            {
                location.Status = "ACTIVE";
            }
            else if (rbLocationInactive.Checked)
            {
                location.Status = "INACTIVE";
            }
            locationManager.UpdateLocation(location.LocationToLocationDTO());
            ClearAllBoxes();
            RefreshLocation();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            if (tbAreaName.Text != string.Empty && rbAreaActive.Checked || rbAreaInactive.Checked)
            {
                AddArea();
            }
            else
            {
                MessageBox.Show("You have to introduce a name for the area");
            }
        }

        private void btnEditArea_Click(object sender, EventArgs e)
        {
            if (tbAreaName.Text != string.Empty && rbAreaActive.Checked || rbAreaInactive.Checked)
            {
                UpdateArea();
            }
            else
            {
                MessageBox.Show("You have to introduce a name for the area");
            }
        }

        private void lbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            area = lbArea.SelectedItem as Area;
            tbAreaName.Text = area.AreaName;
            if (area.Status == "ACTIVE")
            {
                rbAreaActive.Checked = true;
            }
            else if (area.Status == "INACTIVE")
            {
                rbAreaInactive.Checked = true;
            }
        }

        private void lbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = lbLocations.SelectedItem as Location;
            tbLocationName.Text = location.LocationName;
            foreach (Area area in cbArea.Items)
            {
                if (area.AreaID == location.Area.AreaID)
                {
                    cbArea.SelectedItem = area;
                }
            }
            if (location.Status == "ACTIVE")
            {
                rbLocationActive.Checked = true;
            }
            else if (location.Status == "INACTIVE")
            {
                rbLocationInactive.Checked = true;
            }
            tbCapacity.Text = location.Capacity.ToString();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (tbLocationName.Text != string.Empty && rbLocationActive.Checked || rbLocationInactive.Checked)
            {
                AddLocation();
            }
            else
            {
                MessageBox.Show("You have to introduce all the details for the location");
            }
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            if (tbLocationName.Text != string.Empty && rbLocationActive.Checked || rbLocationInactive.Checked)
            {
                UpdateLocation();
            }
            else
            {
                MessageBox.Show("You have to introduce all the details for the location");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
