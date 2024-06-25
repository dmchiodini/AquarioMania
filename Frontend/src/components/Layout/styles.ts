import styled from 'styled-components';

export const GridContainer = styled.div`
  display: grid;
  grid-template-columns: 300px auto;
  grid-template-rows: 350px auto;
  grid-template-areas:
    'MH MH'
    'AS CT';

  height: 100vh;
  width: 100vw;
`;
