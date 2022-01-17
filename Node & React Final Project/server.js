'use strict'
var fs = require('fs');
var path = require('path');
var express = require('express');
var bodyParser = require('body-parser');
var app = express();

var PATIENTS_FILE = path.join(__dirname, 'patient.json');

app.set('port', (process.env.PORT || 3000));

app.use('/', express.static(path.join(__dirname, 'public')));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));

app.get('/api/patient', function(req, res) {
  fs.readFile(PATIENTS_FILE, function(err, data) {
    if (err) {
      console.error(err);
      process.exit(1);
    }
    res.setHeader('Cache-Control', 'no-cache');
    res.json(JSON.parse(data));
  });
});

app.post('/api/patient', function(req, res) {
  fs.readFile(PATIENTS_FILE, function(err, data) {
    if (err) {
      console.error(err);
      process.exit(1);
    }
    var patients = JSON.parse(data);
    // NOTE: In a real implementation, we would likely rely on a database or
    // some other approach (e.g. UUIDs) to ensure a globally unique id. We'll
    // treat Date.now() as unique-enough for our purposes.
    var newPatient = {
      id: Date.now(),
      lastName: req.body.lastName,
      address: req.body.address,
      city: req.body.city,
      pstate: req.body.pstate,
      zip: req.body.zip,
      phone: req.body.phone,
      DoB: req.body.DoB,
      email: req.body.email,
      sex: req.body.sex,
      comment: req.body.comment

    };
        console.log(newPatient);
        patients.push(newPatient);

        fs.writeFile(PATIENTS_FILE, JSON.stringify(patients, null, 6), function (err) {
            if (err) {
                console.error(err);
                process.exit(1);
            }
            res.setHeader('Cache-Control', 'no-cache');
            res.json(patients);
    });
  });
});


app.listen(app.get('port'), function() {
  console.log('Server started: http://localhost:' + app.get('port') + '/');
});
