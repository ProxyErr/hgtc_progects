var PatientBox = React.createClass({
  getInitialState: function() {
    //this will hold all the data being read and posted to the file
    return {data: []};
  },
  loadPatientFromServer: function() {
    $.ajax({
      url: this.props.url,
      dataType: 'json',
      cache: false,
      success: function(data) {
        //set the state with the newly loaded data so the display will update
        this.setState({data: data});
      }.bind(this),
      error: function(xhr, status, err) {
        console.error(this.props.url, status, err.toString());
      }.bind(this)
    });
  },
  componentDidMount: function() {
    //Once the component is fully loaded, we grab the Patient
    this.loadPatientFromServer();
    //... and set an interval to continuously load new data:
    setInterval(this.loadPatientFromServer, this.props.pollInterval);
  },
  render: function() {
    //we list Patient, then show the form for new Patient
    return (
      <div className="PatientBox">
        <header>
          <img src="images/logo-white.svg" alt="Ortho SC" id="logoimg" />
        </header>
        <h1>Patient Entries</h1>
        <PatientList data={this.state.data} />       
      </div>
    );
  }
});

var PatientList = React.createClass({
  render: function() {
    var patientNodes = this.props.data.map(function(patient) {
      //map the data to individual Patient
      return (
        <Patient
          lastName={patient.lastName}
          key={patient.id}
          address={patient.address}
          city={patient.city}
          pstate={patient.pstate}
          zip={patient.zip}
          phone={patient.phone}
          DoB={patient.DoB}
          email={patient.email}
          sex={patient.sex}
          comment={patient.comment}

        >
          
        </Patient>
      );
    });
    //print all the nodes in the list
    return (
      <div className="PatientList">
            <table width = "80%" border = "2">
                <tbody>
                <tr>
                    <th>Last Name</th>
                    <th>Address</th>
                    <th>city</th>
                    <th>state</th>
                    <th>zip</th>
                    <th>phone</th>
                    <th>DoB</th>
                    <th>email</th>
                    <th>sex</th>
                    <th>comments</th>                   
                </tr>        
        {patientNodes}
                </tbody>
            </table>
      </div>
    );
  }
});

var Patient = React.createClass({
  render: function() {
    //display an individual Patient
    return (
      <tr>
        <td>{this.props.lastName}</td>
        <td>{this.props.address}</td>
        <td>{this.props.city}</td>
        <td>{this.props.pstate}</td>
        <td>{this.props.zip}</td>
        <td>{this.props.phone}</td>
        <td>{this.props.DoB}</td>
        <td>{this.props.email}</td>
        <td>{this.props.sex}</td>
        <td>{this.props.comment}</td>
      </tr>
    );
  }
});

ReactDOM.render(
  <PatientBox url="../api/patient" pollInterval={2000} />,
  document.getElementById('content')
);