//Add these methods
// PUT api/Employee/{id}
[HttpPut("{id}")]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
public ActionResult<Employee> Put(int id, [FromBody] Employee updatedEmp)
{
    if (id <= 0)
        return BadRequest("Invalid employee id");

    var existingEmp = _employees.FirstOrDefault(e => e.Id == id);
    if (existingEmp == null)
        return BadRequest("Invalid employee id");

    // Update fields
    existingEmp.Name = updatedEmp.Name;
    existingEmp.Salary = updatedEmp.Salary;
    existingEmp.Permanent = updatedEmp.Permanent;
    existingEmp.Department = updatedEmp.Department;
    existingEmp.Skills = updatedEmp.Skills;
    existingEmp.DateOfBirth = updatedEmp.DateOfBirth;

    return Ok(existingEmp);
}

// DELETE api/Employee/{id}
[HttpDelete("{id}")]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
public ActionResult<Employee> Delete(int id)
{
    if (id <= 0)
        return BadRequest("Invalid employee id");

    var emp = _employees.FirstOrDefault(e => e.Id == id);

    if (emp == null)
        return BadRequest("Invalid employee id");

    _employees.Remove(emp);
    return Ok(emp); // Return deleted employee as confirmation
}
