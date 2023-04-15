const request = require("request");

describe("test end point", () => {
  var server;
  var data = {};
   beforeAll((done) => {
    server = require("../app.js");
    request.get("http://localhost:3000/", (error, res, body) => {
      data.status = res.statusCode;
      data.body = body;
      done()
    });
  });
  afterAll(() => {
    server.close();
  });
  it("test status code", () => {
    expect(data.status).toEqual(200);
  });
  it("test body",()=>{
    expect(data.body).toEqual("One endpoint")
  })
});


describe('Test suite for two endpoints', () => {
    it('should return data from both endpoints', async () => {
      const endpoint1 = 'https://example.com/endpoint1';
      const endpoint2 = 'https://example.com/endpoint2';
  
      const [response1, response2] = await Promise.all([
        fetch(endpoint1),
        fetch(endpoint2)
      ]);
  
      expect(response1.status).toBe(200);
      expect(response2.status).toBe(200);
  
      const data1 = await response1.json();
      const data2 = await response2.json();
  
      expect(data1).toBeDefined();
      expect(data2).toBeDefined();
    });
  });