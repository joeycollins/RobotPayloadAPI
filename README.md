# RobotPayloadAPI

# Instructions:
# 1: Open RobotAPI.sln in visual studio. Build project and run.
# 2: Submit a post request on Postman, make sure Verify SSL certificates is turned off in postman. 
# 2 (alternative): Go to to https://localhost:5000/swagger. This should give a good overview of the API. Expand the Post request type listed (/api/robots/closest). Click "Try it out" and run a post request with a payload.

# Next Steps:
# Ideally we would save all the Payloads into a database and when sending a post request we could supply the loadID only, retrieve the payload coords from the database, and return the closest robot.
