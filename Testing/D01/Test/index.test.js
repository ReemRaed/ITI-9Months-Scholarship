

const { sum, convertToArray, checkPositivity ,capitalizeText,createArray} = require("../index");
const { assert, expect } = require("chai");
const should = require("chai").should();

describe('capitalizeText function', () => {
    before(() => {
      console.log("before");
    });
    after(() => {
      console.log("after");
    });
    beforeEach(() => {
      console.log("beforeEach");
    });
    afterEach(() => {
      console.log("afterEach");
    });
  
    //test that the function takes a string  it will return a string 
    it.skip('should take a string and return a string', () => {
           expect(capitalizeText('hello')).to.be.a('string');
  
           assert.equal(typeof capitalizeText('rehab'),'string')
  
           capitalizeText('rehab').should.to.be.a('string');
    });
    
    //test that the function takes a string and return it after capitalize it
    it('should take a string and return it capitalized', () => {
      expect(capitalizeText('reem')).to.be.a('string');
      expect(capitalizeText('reem')).to.equal('REEM');
  
      assert.strictEqual(typeof capitalizeText('reem'), 'string');//compare return true if have same value and type
      capitalizeText('reem').should.equal('REEM');
  
    });
  
    
  
    //test if the function takes number it will throw type error says parameter should be string
    it('should throw a TypeError if the parameter is not a string', () => {
      assert.throws(() => capitalizeText(123), TypeError, 'parameter should be string');
      expect(() => capitalizeText(123)).throw(TypeError, "parameter should be string");
      (() => capitalizeText(123)).should.Throw(TypeError, "parameter should be string");
  
    });
  
  
  });
  
  
  describe('createArray test Function',()=>{
    //test that the return value of type array
    it("test is array or not",()=>{
      expect(createArray(5)).to.be.an("array");
     assert.isArray(createArray(5));
     createArray(5).should.to.be.an('array');
  
  
    });
  //test if we pass 3 it will return array of length 3 and test it's include 1
  it("test if we pass 3 it will return array of length 3 and test it's include 1",()=>{
    expect(createArray(3)).to.be.an("array").to.have.lengthOf(3).that.includes(1);
    
    createArray(3).should.to.be.an("array").to.have.lengthOf(3).that.includes(1);
  })
  
  })
  
  
  setTimeout(() =>{
    run()
  }, 5000);

// npm test --delay