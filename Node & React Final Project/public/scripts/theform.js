var PatientBox = React.createClass({
    getInitialState: function() {
      //this will hold all the data being read and posted to the file
      return {data: []};
    },
    handlePatientSubmit: function(patient) {
    //this is just an example of how you would submit a form
    //you would have to implement something separately on the server
    $.ajax({
      url: this.props.url,
      dataType: 'json',
      type: 'POST',
      data: patient,
      success: function(data) {
        //We set the state again after submission, to update with the submitted data
        this.setState({data: data});
      }.bind(this),
      error: function(xhr, status, err) {
        console.error(this.props.url, status, err.toString());
      }.bind(this)
    });
  },
  render: function() {
    return (
      <div className="PatientBox">
        <div id="search-nav">
          <img src="images/search.png" alt="search" id="searchimg" />         
        </div>
        <header id="PatientHeader">
          <div>
            <img src="images/logo.svg" alt="Ortho SC" id="logoimg1" /> 
          </div>
          <div>
            <img src="images/slogan.jpg" alt="slogan" id="sloganimg" />
          </div>
        </header>
        <section>
          <div id="contact-nav">
            <img src="images/contact.png" alt="contact" id="contactimg" />
          </div>
          <div id="main-nav">
          <nav>
              <ul>
                <li><img src="images/home.png" alt="home" id="home" /></li>
                <li>DOCTORS</li>
                <li>SPECIALTIES</li>
                <li>lOCATIONS</li>
                <li>SERVICES</li>
                <li>PATIENT RESOURCES</li>
                <li>ABOUT US</li>            
              </ul>
            </nav>
          </div>
        </section>
                
        <PatientForm  onPatientSubmit = {this.handlePatientSubmit}/>
      </div>
    );
  }
});

var PatientForm = React.createClass({
  getInitialState: function() {
    return {
        lastName: "",
        firstName: "",
        address: "",
        city: "",
        pstate: "",
        zip: "",
        phone: "",
        DoB: "",
        email: "",
        sex: "",
        comment: "",
        allergies: "",
        surgeries: "",
        conditions: "",
        newsletter: ""

    };
  },
  handleSubmit: function(e) {
      //we don't want the form to submit, so we prevent the defaul behavior
      e.preventDefault();
      
      
      //we clean up the data as we save it
      var lastName = this.state.lastName.trim();
      var address = this.state.address.trim();
      var city = this.state.city.trim();
      var pstate = this.state.pstate.trim();
      var zip = this.state.zip.trim();
      var phone = this.state.phone.trim();
      var DoB = this.state.DoB.trim();
      var email = this.state.email.trim();
      var sex = this.state.sex.trim();
      var comment = this.state.comment.trim(" ");


      
      
      //Here we do the final submit to the parent component
      this.props.onPatientSubmit({lastName: lastName, address: address,
                                  city: city, pstate: pstate, zip: zip,
                                phone: phone, DoB: DoB, email: email, 
                                sex: sex, comment: comment});
    
      //Now that the form is submitted, we empty all the fields
      this.setState({
        lastName: "",
        firstName: "",
        address: "",
        city: "",
        pstate: "",
        zip: "",
        phone: "",
        DoB: "",
        email: "",
        sex: "",
        comment: "",
        allergies: "",
        surgeries: "",
        conditions: "",
        newsletter: ""
      });
    },
  validateEmail: function (value) {
    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(value);
  },
  commonValidate: function () {
    return true;
  },
  phoneValidate: function () {
    var reg = /^[+]?[(]?[0-9]{3}[)]?[-\s.]?[0-9]{3}[-\s.]?[0-9]{4,6}$/im;
    return reg.test(value);
  },
  setValue: function (field, event) {
    var object = {};
    object[field] = event.target.value;
    this.setState(object);
},
  render: function() {
    //Each form field is actually another component.
    //Two of the form fields use the same component, but with different variables
    return (
      <form className="PatientForm" onSubmit={this.handleSubmit}>
        <div id="infoinput">
          <img src="images/logo-white.svg" alt="Ortho SC" id="logoimg" />
          <h2>Initial Medical Form:</h2>
          

          <h5>Last Name:</h5>
          <TextInput
            value={this.state.lastName}
            uniqueName="lastName"
            text="Last Name"
            textArea={false}
            required={true}
            minCharacters={3}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'lastName')} 
            errorMessage="Last Name is invalid"
            emptyMessage="Last Name is required" />
          <br />


          <h5>First Name:</h5>
          <TextInput
            value={this.state.firstName}
            uniqueName="firstName"
            text="First Name"
            textArea={false}
            required={false}
            minCharacters={3}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'firstName')} 
            errorMessage=""
            emptyMessage="" />
          <br />


          <h5>Address:</h5>
          <TextInput
            value={this.state.address}
            uniqueName="address"
            text="Address"
            textArea={false}
            required={false}
            minCharacters={3}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'address')} 
            errorMessage="Address Invalid"
            emptyMessage="Address Required" />
          <br />


          <h5>City:</h5>
          <TextInput
            value={this.state.city}
            uniqueName="city"
            text="City"
            textArea={false}
            required={false}
            minCharacters={3}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'city')} 
            errorMessage="City is invalid"
            emptyMessage="City is required" />
          <br />


          <h5>State:</h5>
          <TextInput
            value={this.state.pstate}
            uniqueName="pstate"
            text="State:"
            textArea={false}
            required={false}
            minCharacters={3}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'pstate')} 
            errorMessage="State is invalid"
            emptyMessage="State is required" />
          <br />


          <h5>Zip:</h5>
          <TextInput
            value={this.state.zip}
            uniqueName="zip"
            text="zip"
            textArea={false}
            required={true}
            minCharacters={5}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'zip')} 
            errorMessage="Zip is invalid"
            emptyMessage="Zip is required" />
          <br />


          <h5>Phone:</h5>
          <TextInput
            value={this.state.phone}
            uniqueName="phone"
            text="phone"
            textArea={false}
            required={false}
            minCharacters={3}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'phone')} 
            errorMessage=""
            emptyMessage="" />
          <br />


          <h5>Date Of Birth:</h5>
          <TextInput
            value={this.state.DoB}
            uniqueName="DoB"
            text="DoB(YYYY-DD-MM)"
            textArea={false}
            required={false}
            minCharacters={3}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'DoB')} 
            errorMessage=""
            emptyMessage="" />
          <br />


          <h5>Email:</h5>
          <TextInput
            value={this.state.email}
            uniqueName="email"
            text="Email Address"
            textArea={false}
            required={true}
            minCharacters={6}
            validate={this.validateEmail}
            onChange={this.setValue.bind(this, 'email')} 
            errorMessage="Email is invalid"
            emptyMessage="Email is required" />
          <br />


          <h5>Sex:</h5>
          <TextInput
            value={this.state.sex}
            uniqueName="sex"
            text="Male / Female"
            textArea={false}
            required={false}
            minCharacters={1}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'sex')} 
            errorMessage="Sex is invalid"
            emptyMessage="Sex is required" />
          <br />

          <h3>Comments or Ask a Question:</h3>
          <h5>(Choose a department you are looking for)</h5>
          <TextInput
            value={this.state.comment}
            uniqueName="comment"
            text="Comments"
            textArea={true}
            required={false}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'comment')} 
            errorMessage=""
            emptyMessage="" />
          <br />

          <h5>Allergies:</h5>
          <TextInput
            value={this.state.allergies}
            uniqueName="allergies"
            text="Allergies"
            textArea={true}
            required={false}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'allergies')} 
            errorMessage=""
            emptyMessage="" />
          <br />


          <h5>Past Surgeries:</h5>
          <TextInput
            value={this.state.surgeries}
            uniqueName="surgeries"
            text="Surgeries"
            textArea={true}
            required={false}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'surgeries')} 
            errorMessage=""
            emptyMessage="" />
          <br />


          <h5>Any Serious Conditions:</h5>
          <TextInput
            value={this.state.conditions}
            uniqueName="conditions"
            text="Conditions"
            textArea={true}
            required={false}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'conditions')} 
            errorMessage=""
            emptyMessage="" />
          <br />


          <h5>Would you like to recieve our weekly news letter?</h5>
          <h6>(Type Yes or No)</h6>
          <TextInput
            value={this.state.newsletter}
            uniqueName="newsletter"
            text="Newsletter"
            textArea={false}
            required={false}
            minCharacters={3}
            validate={this.commonValidate}
            onChange={this.setValue.bind(this, 'newsletter')} 
            errorMessage=""
            emptyMessage="" />
          <br />
  
          <input type="submit" value="Submit" />
        </div>
      </form>
    );
  }
});

var InputError = React.createClass({
  getInitialState: function() {
    return {
      message: 'Input is invalid'
    };
  },
  render: function(){ 
    var errorClass = classNames(this.props.className, {
      'error_container':   true,
      'visible':           this.props.visible,
      'invisible':         !this.props.visible
    });

    return (
      <div className={errorClass}>
        <span>{this.props.errorMessage}</span>
      </div>
    )
  }

});

var TextInput = React.createClass({
  getInitialState: function(){
    //most of these variables have to do with handling errors
    return {
      isEmpty: true,
      value: null,
      valid: false,
      errorMessage: "",
      errorVisible: false
    };
  },

  handleChange: function(event){
    //validate the field locally
    this.validation(event.target.value);

    //Call onChange method on the parent component for updating it's state
    //If saving this field for final form submission, it gets passed
    // up to the top component for sending to the server
    if(this.props.onChange) {
      this.props.onChange(event);
    }
  },

  validation: function (value, valid) {
    //The valid variable is optional, and true if not passed in:
    if (typeof valid === 'undefined') {
        valid = true;
    }
    
    var message = "";
    var errorVisible = false;
    
    //we know how to validate text fields based on information passed through props
    if (!valid) {
      //This happens when the user leaves the field, but it is not valid
      //(we do final validation in the parent component, then pass the result
      //here for display)
      message = this.props.errorMessage;
      valid = false;
      errorVisible = true;
    }
    else if (this.props.required && jQuery.isEmptyObject(value)) {
      //this happens when we have a required field with no text entered
      //in this case, we want the "emptyMessage" error message
      message = this.props.emptyMessage;
      valid = false;
      errorVisible = true;
    }
    else if (value.length < this.props.minCharacters) {
      //This happens when the text entered is not the required length,
      //in which case we show the regular error message
      message = this.props.errorMessage;
      valid = false;
      errorVisible = true;
    }
    
    //setting the state will update the display,
    //causing the error message to display if there is one.
    this.setState({
      value: value,
      isEmpty: jQuery.isEmptyObject(value),
      valid: valid,
      errorMessage: message,
      errorVisible: errorVisible
    });

  },

  handleBlur: function (event) {
    //Complete final validation from parent element when complete
    var valid = this.props.validate(event.target.value);
    //pass the result to the local validation element for displaying the error
    this.validation(event.target.value, valid);
  },
  render: function() {
    if (this.props.textArea) {
      return (
        <div className={this.props.uniqueName}>
          <textarea
            placeholder={this.props.text}
            className={'input input-' + this.props.uniqueName}
            onChange={this.handleChange}
            onBlur={this.handleBlur}
            value={this.props.value} />
      
          <InputError 
            visible={this.state.errorVisible} 
            errorMessage={this.state.errorMessage} />
        </div>
        );
    } else {
      return (
        <div className={this.props.uniqueName}>
          <input
            placeholder={this.props.text}
            className={'input input-' + this.props.uniqueName}
            onChange={this.handleChange}
            onBlur={this.handleBlur}
            value={this.props.value} />
      
          <InputError 
            visible={this.state.errorVisible} 
            errorMessage={this.state.errorMessage} />
        </div>
      );
    }
  }
});


ReactDOM.render(
  <PatientBox url="api/patient" pollInterval={2000}/>,
  document.getElementById('content')
);