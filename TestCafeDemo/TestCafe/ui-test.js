﻿//.tc01
import { Selector } from 'testcafe';
const dataSet = require('./data.json');
fixture`Getting started fixture`
    .page`https://localhost:44374/`;

test('Registration Fixture', async t => {
    await t
		.typeText('#frmName', 'don')
     .typeText('#frmEmail', 'donw@devexpress.com')
        .click('#register')
     
           .expect(Selector('#response').textContent).eql("Thank you don you will receive an email at donw@devexpress.com");
});

dataSet.forEach(data => {
    test(`Processing '${data.name}'`, async t => {
        await t
            .typeText('#frmName', data.name)
            .typeText('#frmEmail', data.email)
            .click('#register')

            .expect(Selector('#response').textContent).eql(data.resultText);
    });
});
