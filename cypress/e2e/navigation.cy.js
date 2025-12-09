describe('example to-do app', () => {
    beforeEach(() => {
      cy.visit('http://localhost:3000/perfumes')
    })

    it('number-of-products',() => {
        // We use the `cy.get()` command to get all elements that match the selector.
        // Then, we use `should` to a sert that there are two matched items,
        // which are the two default items.
        cy.get('.perfume').should('have.length', 30)})

})