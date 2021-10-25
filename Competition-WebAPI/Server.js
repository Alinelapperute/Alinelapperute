const cors = require('cors')
express = require('express')
const app = express()
const axios = require('axios')

app.use(cors())

app.get('/', async (req, res) => {

    try {
        const { data } = await axios('https://l3-processoseletivo.azurewebsites.net/api/Competidores?copa=games')


        return res.json(data)

    } catch (error) {
        console.error(error)
    }

})

app.listen(4567)